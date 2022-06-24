using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEngine;

public class Res2AssetBundleImport : AssetPostprocessor
{
    public static void OnPostprocessAllAssets(string[] importedAssets, string[] deletedAssets, string[] movedAssets, string[] movedFromAssetPaths)
    {
#if !UNITY_IOS
        foreach (var str in importedAssets)
        {
            AutoName(str, Path.GetDirectoryName(str));
        }

        foreach (var str in movedAssets)
        {
            AutoName(str, Path.GetDirectoryName(str));
        }
#endif
    }

    static void AutoName(string path,string rootPath)
    {
        if (!CheckPath(path)) return;

        if (path.Contains("JMain/BuildAsset/Atlas"))
        {
            AssetImporter item = AssetImporter.GetAtPath(path);
            string fileName = Path.GetFileNameWithoutExtension(path);
            item.assetBundleName = "atlas/" + fileName.ToLower();
        }

        if (path.Contains("JMain/BuildAsset/UI"))
        {
            AssetImporter item = AssetImporter.GetAtPath(path);
            string fileName = Path.GetFileNameWithoutExtension(path);
            item.assetBundleName = "ui/" + fileName.ToLower();
        }

        if (path.Contains("JMain/BuildAsset/Prefab"))
        {
            AssetImporter item = AssetImporter.GetAtPath(path);
            string fileName = Path.GetFileNameWithoutExtension(path);
            item.assetBundleName = "prefab/" + fileName.ToLower();
        }

        if (path.Contains("JMain/BuildAsset/materials"))
        {
            AssetImporter item = AssetImporter.GetAtPath(path);
            string fileName = Path.GetFileNameWithoutExtension(path);
            item.assetBundleName = "mat/" + fileName.ToLower();
        }

        if (path.Contains("JMain/BuildAsset/Music"))
        {
            AssetImporter item = AssetImporter.GetAtPath(path);
            string fileName = Path.GetFileNameWithoutExtension(path);
            item.assetBundleName = "music/" + fileName.ToLower();
        }

        if (path.Contains("JMain/BuildAsset/Effect"))
        {
            AssetImporter item = AssetImporter.GetAtPath(path);
            string fileName = Path.GetFileNameWithoutExtension(path);
            item.assetBundleName = "effect/" + fileName.ToLower();
        }
    }
    
    private static bool CheckPath(string path)
    {
        if (path.EndsWith(".meta") ||
            path.EndsWith(".cs") ||
            path.EndsWith(".tpsheet") 
            )
            return false;
        return true;
    }

}
