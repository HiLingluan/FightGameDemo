using System;
using System.Collections.Generic;
using UnityEngine;
using XLua;
using System.Reflection;
using System.Linq;
using UnityEngine.UI;
using TMPro;
using UnityEngine.EventSystems;
using GameFramework.Resource;

public static class XLuaConfig
{

    [ReflectionUse]
    [LuaCallCSharp]
    public static List<Type> lua_call_cs_list = new List<Type>()
    {
        #region DOTween
   
        #endregion
        typeof(SystemInfo),
        typeof(Mathf),
        typeof(Color),
        typeof(Resources),
        typeof(SpriteRenderer),
        typeof(TimeSpan),
        typeof(DateTime),
        typeof(PointerEventData),
        typeof(GUIUtility),

    };

    [LuaCallCSharp]
    public static List<Type> LuaCallCSharp
    {
        get
        {
            List<Type> types = new List<Type>();
            types.AddRange((from type in Assembly.Load("UnityEngine.UI").GetExportedTypes()
                            where NamespaceFilt(type)
                            select type).ToList());

            //types.AddRange((from type in Assembly.GetAssembly(typeof(GameObject)).GetExportedTypes()
            //                where type.Namespace.Contains("UnityEngine")
            //                where NamespaceFilt(type)
            //                select type).ToList());
            return types;
        }
    }

    public static bool NamespaceFilt(Type type)
    {
        string nameSpace = type.Namespace;
#if UNITY_ANDROID
        if (nameSpace.Contains("UnityEngine.iOS") || nameSpace.Contains("UnityEngine.tvOS") ||
            nameSpace.Contains("UnityEngine.Windows") || nameSpace.Contains("UnityEngine.WSA") ||
             nameSpace.Contains("UnityEngine.Apple"))
            return false;
#elif UNITY_IOS
         if (nameSpace.Contains("UnityEngine.Android") || nameSpace.Contains("UnityEngine.tvOS") ||
                    nameSpace.Contains("UnityEngine.Windows") || nameSpace.Contains("UnityEngine.WSA")||
                 nameSpace.Contains("UnityEngine.Apple"))
                return false;
#endif
        if (type == typeof(UnityEngine.UI.GraphicRebuildTracker) ||
            type == typeof(UnityEngine.iPhoneUtils)
            )
            return false;
        return true;
    }

    [CSharpCallLua]
    public static List<Type> cs_call_lua_list = new List<Type>()
    {
        // typeof(UINetSprite),
        typeof(Action<Texture2D>), //单张图片下载的回调
        typeof(Action<object,string[]>),
        typeof(UnityEngine.Events.UnityAction<UnityEngine.Vector2>),
        typeof(Func<UnityEngine.GameObject, System.Nullable<bool>>),
        typeof(Action<string, int>),
        typeof(Action),
        typeof(Action<LuaTable>),
        typeof(Action<MonoBehaviour>),
        typeof(Action<MonoBehaviour,bool>),
        typeof(Action<float>),
        typeof(Action<bool>),
        typeof(Action<int>),
        typeof(Action<int,int>),
        typeof(Action<int,string>),
        typeof(Action<string>),
        typeof(Action<object>),
        typeof(Action<Exception>),
        typeof(EventHandler),
        typeof(Func<object>),

        //GameFramework
        typeof(LoadAssetCallbacks),

    };

    [LuaCallCSharp]
    public static List<Type> luaCallCS_List
    {
        get
        {
            return (from type in Assembly.Load("Assembly-CSharp").GetTypes()
                    where type.Namespace == "ZFight" || type.Namespace == "UnityGameFramework.Runtime"
                    select type).ToList();
        }
    }

    //黑名单
    [BlackList]
    public static List<List<string>> BlackList = new List<List<string>>()  {
        new List<string>(){"System.Xml.XmlNodeList", "ItemOf"},
        new List<string>(){"UnityEngine.WWW", "movie"},
        new List<string>(){"UnityEngine.UI.Text", "OnRebuildRequested"},
        new List<string>(){ "UnityEngine.UI.Graphic", "OnRebuildRequested"},
        new List<string>(){ "UnityEngine.UI.DefaultControls", "factory" },

        new List<string>(){"UnityEngine.Texture2D", "alphaIsTransparency"},
        new List<string>(){"UnityEngine.Security", "GetChainOfTrustValue"},
        new List<string>(){"UnityEngine.CanvasRenderer", "onRequestRebuild"},
        new List<string>(){"UnityEngine.Light", "areaSize"},
        new List<string>(){"UnityEngine.Light", "SetLightDirty"},
        new List<string>(){"UnityEngine.Light", "lightmapBakeType"},
        new List<string>(){"UnityEngine.Light", "shadowRadius"},
        new List<string>(){"UnityEngine.Light", "shadowAngle"},

        new List<string>(){"UnityEngine.WWW", "MovieTexture"},
        new List<string>(){"UnityEngine.WWW", "GetMovieTexture"},
        new List<string>(){"UnityEngine.AnimatorOverrideController", "PerformOverrideClipListCleanup"},
        new List<string>(){ "UnityEngine.ParticleSystemRenderer", "supportsMeshInstancing" },
        new List<string>(){ "UnityEngine.Texture", "imageContentsHash" },
        // new List<string>(){ "UnityEngine.MeshRenderer", "scaleInLightmap" },
        //new List<string>(){ "UnityEngine.MeshRenderer", "receiveGI" },
        new List<string>(){ "UnityEngine.QualitySettings", "streamingMipmapsRenderersPerFrame" },
        new List<string>(){ "JMatrix.CSUtil", "AssetDatabaseLoadPathAnimationClip", "System.String", "System.String" },
        // new List<string>(){ "UnityEngine.MeshRenderer", "stitchLightmapSeams" },
        new List<string>(){ "UnityEngine.Input", "IsJoystickPreconfigured" ,"System.String"},
        new List<string>(){"UnityEngine.GameObject", "networkView"}, //4.6.2 not support
        new List<string>(){"UnityEngine.Component", "networkView"},  //4.6.2 not support
        new List<string>(){"System.IO.FileInfo", "GetAccessControl", "System.Security.AccessControl.AccessControlSections"},
        new List<string>(){"System.IO.FileInfo", "SetAccessControl", "System.Security.AccessControl.FileSecurity"},
        new List<string>(){"System.IO.DirectoryInfo", "GetAccessControl", "System.Security.AccessControl.AccessControlSections"},
        new List<string>(){"System.IO.DirectoryInfo", "SetAccessControl", "System.Security.AccessControl.DirectorySecurity"},
        new List<string>(){"System.IO.DirectoryInfo", "CreateSubdirectory", "System.String", "System.Security.AccessControl.DirectorySecurity"},
        new List<string>(){"System.IO.DirectoryInfo", "Create", "System.Security.AccessControl.DirectorySecurity"},
        new List<string>(){"UnityEngine.MonoBehaviour", "runInEditMode"},
        new List<string>(){"JMatrix.AssetContainer","GetContainerList" },
        new List<string>(){"JMatrix.AssetContainer","GetAssetObjects" },

     };
    [BlackList]
    public static Func<MemberInfo, bool> MethodFilter = (memberInfo) =>
    {
        if (memberInfo.DeclaringType.IsGenericType && memberInfo.DeclaringType.GetGenericTypeDefinition() == typeof(Dictionary<,>))
        {
            if (memberInfo.MemberType == MemberTypes.Constructor)
            {
                ConstructorInfo constructorInfo = memberInfo as ConstructorInfo;
                var parameterInfos = constructorInfo.GetParameters();
                if (parameterInfos.Length > 0)
                {
                    if (typeof(System.Collections.IEnumerable).IsAssignableFrom(parameterInfos[0].ParameterType))
                    {
                        return true;
                    }
                }
            }
            else if (memberInfo.MemberType == MemberTypes.Method)
            {
                var methodInfo = memberInfo as MethodInfo;
                if (methodInfo.Name == "TryAdd" || methodInfo.Name == "Remove" && methodInfo.GetParameters().Length == 2)
                {
                    return true;
                }
            }
        }
        return false;
    };



}


