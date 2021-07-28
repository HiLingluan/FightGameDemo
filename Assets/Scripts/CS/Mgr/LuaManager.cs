using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using UnityEngine;
using XLua;

public class LuaManager : MonoBehaviour
{
    internal static LuaEnv luaEnv;
    internal static float lastGCTime = 0;
    internal const float GCInterval = 1; 

    private Action luaStart;
    private Action luaUpdate;
    private Action luaLateUpdate;
    private Action luaOnDestroy;

    void Awake()
    {
        luaEnv = new LuaEnv();
        luaEnv.AddLoader(CustomLoader);
        luaEnv.DoString(@"
            require 'Main'
        ");
        Action luaAwake = luaEnv.Global.Get<Action>("Awake");

        luaStart = luaEnv.Global.Get<Action>("Start");
        luaUpdate = luaEnv.Global.Get<Action>("Update");
        luaLateUpdate = luaEnv.Global.Get<Action>("LateUpdate");
        luaOnDestroy = luaEnv.Global.Get<Action>("OnDestroy");
        luaAwake?.Invoke();
    }

    void Start()
    {
        luaStart?.Invoke();
    }

    void Update()
    {
        luaUpdate?.Invoke();
        if (Time.time - lastGCTime > GCInterval)
        {
            luaEnv.Tick();
            lastGCTime = Time.time;
        }
    }

    void LateUpdate()
    {
        luaLateUpdate?.Invoke();
    }

    void OnDestroy()
    {
        luaOnDestroy?.Invoke();
        luaOnDestroy = null;
        luaUpdate = null;
        luaStart = null;
    }

    byte[] CustomLoader(ref string filepath)
    {
        string fullPath = AssetPathHelper.BuildInLuaPath + filepath;
        string fileName = fullPath.Replace('.', '/') + ".lua";
        if (File.Exists(fileName))
        {
            string context = File.ReadAllText(fileName);
            return System.Text.Encoding.UTF8.GetBytes(context);
        }
        else
        {
            return null;
        }
    }
    
}