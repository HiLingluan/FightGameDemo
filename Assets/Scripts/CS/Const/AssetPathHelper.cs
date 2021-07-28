using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class AssetPathHelper 
{

    public readonly static string streamingAssetsPath = Application.streamingAssetsPath;
    public readonly static string persistentDataPath = Application.persistentDataPath;
    public readonly static string temporaryCachePath = Application.temporaryCachePath;
    public readonly static string dataPath = Application.dataPath;

    #region lua resource path
    public readonly static string BuildInLuaPath = dataPath + "/Scripts/Lua/";
    public readonly static string LuaFolderPath = persistentDataPath + "/Lua/";
    public readonly static string mainLuaPath = BuildInLuaPath + "Main.lua";
    public readonly static string disposeLuaPath = BuildInLuaPath + "Dispose.lua";
    #endregion
}
