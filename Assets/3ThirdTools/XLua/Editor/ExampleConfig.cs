using System;
using System.Collections.Generic;
using UnityEngine;
using XLua;
using DG.Tweening;
using System.Reflection;
using System.Linq;

using SuperScrollView;
using UnityEngine.UI;
using TMPro;
using UnityEngine.EventSystems;
using GameFramework.Event;
using UnityGameFramework.Runtime;
using GameFramework.Resource;

public static class XLuaConfig
{

    /***************如果你全lua编程，可以参考这份自动化配置***************/
    //--------------begin 纯lua编程配置参考----------------------------
    //static List<string> exclude = new List<string> {
    //    "HideInInspector", "ExecuteInEditMode",
    //    "AddComponentMenu", "ContextMenu",
    //    "RequireComponent", "DisallowMultipleComponent",
    //    "SerializeField", "AssemblyIsEditorAssembly",
    //    "Attribute", "Types",
    //    "UnitySurrogateSelector", "TrackedReference",
    //    "TypeInferenceRules", "FFTWindow",
    //    "RPC", "Network", "MasterServer",
    //    "BitStream", "HostData",
    //    "ConnectionTesterStatus", "GUI", "EventType",
    //    "EventModifiers", "FontStyle", "TextAlignment",
    //    "TextEditor", "TextEditorDblClickSnapping",
    //    "TextGenerator", "TextClipping", "Gizmos",
    //    "ADBannerView", "ADInterstitialAd",
    //    "Android", "Tizen", "jvalue",
    //    "iPhone", "iOS", "Windows", "CalendarIdentifier",
    //    "CalendarUnit", "CalendarUnit",
    //    "ClusterInput", "FullScreenMovieControlMode",
    //    "FullScreenMovieScalingMode", "Handheld",
    //    "LocalNotification", "NotificationServices",
    //    "RemoteNotificationType", "RemoteNotification",
    //    "SamsungTV", "TextureCompressionQuality",
    //    "TouchScreenKeyboardType", "TouchScreenKeyboard",
    //    "MovieTexture", "UnityEngineInternal",
    //    "Terrain", "Tree", "SplatPrototype",
    //    "DetailPrototype", "DetailRenderMode",
    //    "MeshSubsetCombineUtility", "AOT", "Social", "Enumerator",
    //    "SendMouseEvents", "Cursor", "Flash", "ActionScript",
    //    "OnRequestRebuild", "Ping",
    //    "ShaderVariantCollection", "SimpleJson.Reflection",
    //    "CoroutineTween", "GraphicRebuildTracker",
    //    "Advertisements", "UnityEditor", "WSA",
    //    "EventProvider", "Apple",
    //    "ClusterInput", "Motion",
    //    "UnityEngine.UI.ReflectionMethodsCache", "NativeLeakDetection",
    //    "NativeLeakDetectionMode", "WWWAudioExtensions", "UnityEngine.Experimental",
    //};

    //static bool isExcluded(Type type)
    //{
    //    var fullName = type.FullName;
    //    for (int i = 0; i < exclude.Count; i++)
    //    {
    //        if (fullName.Contains(exclude[i]))
    //        {
    //            return true;
    //        }
    //    }
    //    return false;
    //}

    //[LuaCallCSharp]
    //public static IEnumerable<Type> LuaCallCSharp
    //{
    //    get
    //    {
    //        List<string> namespaces = new List<string>() // 在这里添加名字空间
    //        {
    //            "UnityEngine.MeshRenderer",
    //            "Live2D",
    //            "UnityEngine.UI"
    //        };
    //        var unityTypes = (from assembly in AppDomain.CurrentDomain.GetAssemblies()
    //                          where !(assembly.ManifestModule is System.Reflection.Emit.ModuleBuilder)
    //                          from type in assembly.GetExportedTypes()
    //                          where type.Namespace != null && namespaces.Contains(type.Namespace) && !isExcluded(type)
    //                                  && type.BaseType != typeof(MulticastDelegate) && !type.IsInterface && !type.IsEnum
    //                          select type);

    //        string[] customAssemblys = new string[] {
    //            "Assembly-CSharp",
    //        };
    //        var customTypes = (from assembly in customAssemblys.Select(s => Assembly.Load(s))
    //                           from type in assembly.GetExportedTypes()
    //                           where type.Namespace == null || !type.Namespace.StartsWith("XLua")
    //                                   && type.BaseType != typeof(MulticastDelegate) && !type.IsInterface && !type.IsEnum
    //                           select type);
    //        return unityTypes.Concat(customTypes);
    //    }
    //}

    [ReflectionUse]
    [LuaCallCSharp]
    public static List<Type> lua_call_cs_list = new List<Type>()
    {
        #region DOTween
        typeof(DG.Tweening.AutoPlay),
        typeof(DG.Tweening.AxisConstraint),
        typeof(DG.Tweening.Ease),
        typeof(DG.Tweening.LogBehaviour),
        typeof(DG.Tweening.LoopType),
        typeof(DG.Tweening.PathMode),
        typeof(DG.Tweening.PathType),
        typeof(DG.Tweening.RotateMode),
        typeof(DG.Tweening.ScrambleMode),
        typeof(DG.Tweening.TweenType),
        typeof(DG.Tweening.UpdateType),

        typeof(DG.Tweening.DOTween),
        typeof(DG.Tweening.DOVirtual),
        typeof(DG.Tweening.EaseFactory),
        typeof(DG.Tweening.Tweener),
        typeof(DG.Tweening.Tween),
        typeof(DG.Tweening.Sequence),
        typeof(DG.Tweening.TweenParams),
        typeof(DG.Tweening.Core.ABSSequentiable),

        typeof(DG.Tweening.Core.TweenerCore<Vector3, Vector3, DG.Tweening.Plugins.Options.VectorOptions>),

        typeof(DG.Tweening.TweenCallback),
        typeof(DG.Tweening.TweenExtensions),
        typeof(DG.Tweening.TweenSettingsExtensions),
        typeof(DG.Tweening.ShortcutExtensions),
        typeof(DOTweenModuleUI),
        #endregion
        typeof(SystemInfo),
        typeof(Mathf),
        typeof(Color),
        typeof(Resources),
        typeof(SpriteRenderer),
        typeof(LoopListView2),
        typeof(TimeSpan),
        typeof(DateTime),
        typeof(PointerEventData),
        typeof(Tween),
        typeof(GUIUtility),
        typeof(Camera),
        //=================JMatrix=================
        typeof(SimpleAnimation),
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
        typeof(BestHTTP.OnDownloadProgressDelegate),
        typeof(Func<UnityEngine.GameObject, System.Nullable<bool>>),
        typeof(Action<string, int>),
        typeof(Action),
        typeof(Action<LuaTable>),
        typeof(Action<MonoBehaviour>),
        typeof(Action<MonoBehaviour,bool>),
        typeof(Action<float>),
        typeof(Action<bool>),
        typeof(Action<bool,object>),
        typeof(Action<int>),
        typeof(Action<int,int>),
        typeof(Action<int,string>),
        typeof(Action<int,object>),
        typeof(Action<float,float>),

        typeof(Action<string>),
        typeof(Action<object>),
        typeof(Action<Exception>),
        typeof(EventHandler),
        typeof(Func<object>),
        typeof(Func<LoopListView2, int, LoopListViewItem2>),
        typeof(Action<TMP_TextInfo>),
        typeof(Action<PointerEventData>),
        typeof(EventHandler<GameEventArgs>),

        typeof(Action<EntityLogic,Transform,object>),
        typeof(Action<EntityLogic,object>),
        typeof(LoadAssetSuccessCallback),
        typeof(LoadAssetFailureCallback),
};

    [LuaCallCSharp]
    public static List<Type> luaCallCS_List
    {
        get
        {
            return (from type in Assembly.Load("Assembly-CSharp").GetTypes()
                    where type.Namespace == "JMatrix" || type.Namespace == "UnityGameFramework.Runtime" || type.Namespace == "UnityGameFramework.Resource"
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
        new List<string>(){"UnityEngine.Light", "lightmapBakeType"},
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


