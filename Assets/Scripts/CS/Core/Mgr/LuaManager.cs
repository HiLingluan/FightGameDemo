using GameFramework.Resource;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using UnityEngine;
using UnityGameFramework.Runtime;
using XLua;

namespace ZFight
{
    public class LuaManager : GameFrameworkComponent
    {
        internal static LuaEnv luaEnv;
        internal static float lastGCTime = 0;
        internal const float GCInterval = 1;

        static LuaLooper luaLooper;
        public static Dictionary<string, byte[]> LuaScriptsDict;

        protected override void Awake()
        {
            luaEnv = new LuaEnv();
        }

        public void Init()
        {
            Log.Debug("LuaManger Init");
            LuaScriptsDict = new Dictionary<string, byte[]>();
            if (GameEntry.Base.EditorResourceMode)
            {
                DirectoryInfo dir = new DirectoryInfo(AssetPathHelper.BuildInLuaPath);
                LoadLuaFromDirectory(dir);
                luaEnv.AddLoader(CustomLoader);
                luaEnv.DoString("require('Main')");
                InitLuaLooper();
            }
            else
            {
                GameEntry.Resource.LoadBytes("Lua", new LoadBytesCallbacks(LoadLuaSuccessCallBack),null);
            }
        }
        
        void LoadLuaSuccessCallBack(string binaryAssetName, byte[] binaryBytes, float duration, object userData)
        {
            AssetBundle ab = AssetBundle.LoadFromMemory(binaryBytes);
            var assetList = ab.LoadAllAssets<TextAsset>();
            foreach (var luaItem in assetList)
            {
                string name = luaItem.name.Replace(".lua", "");
                if (LuaScriptsDict.ContainsKey(name))
                {
                    Log.Warning("Check LuaScriptsDict Key : " + name);
                    LuaScriptsDict[name] = luaItem.bytes;
                }
                else
                    LuaScriptsDict.Add(name, luaItem.bytes);
            }

            luaEnv.AddLoader(CustomLoader);
            luaEnv.DoString("require('Main')");
            InitLuaLooper();
        }

        void Update()
        {
            if (Time.time - lastGCTime > GCInterval)
            {
                luaEnv.Tick();
                lastGCTime = Time.time;
            }
        }

        byte[] CustomLoader(ref string filePath)
        {
            if (LuaScriptsDict.ContainsKey(filePath))
            {
                return LuaScriptsDict[filePath];
            }
            return null;
        }

        void InitLuaLooper()
        {
            if (luaLooper == null)
            {
                GameObject loop = new GameObject("LuaLooper");
                luaLooper = loop.AddComponent<LuaLooper>();
            }
        }

        public void Dispose()
        {
            if (luaEnv != null)
            {
                luaEnv.Dispose();
                luaEnv = null;
            }
            LuaScriptsDict = null;
        }

        void LoadLuaFromDirectory(DirectoryInfo directory)
        {
            FileInfo[] files = directory.GetFiles();
            DirectoryInfo[] directories = directory.GetDirectories();
            foreach (var file in files)
            {
                if (file.Name.Contains(".meta"))
                    continue;
                string name = file.Name.Replace(".lua.txt", "");
                byte[] context = Encoding.UTF8.GetBytes(File.ReadAllText(file.FullName));
                if (LuaScriptsDict.ContainsKey(name))
                {
                    Log.Debug("Check LuaScriptsDict Key : " + name);
                    LuaScriptsDict[name] = context;
                }
                else
                    LuaScriptsDict.Add(name, context);
            }
            foreach (var item in directories)
            {
                LoadLuaFromDirectory(item);
            }
        }

    }
}