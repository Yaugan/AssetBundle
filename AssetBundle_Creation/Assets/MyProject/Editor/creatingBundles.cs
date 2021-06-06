using UnityEditor;
using UnityEngine;
using System.IO; //Added to create folders in Unity.
public class creatingBundles
{
    //Used to create a menu item called Build AssetBundles to build asset bundles directly using this.
    [MenuItem("Assets/Build AssetBundles")]
    static void BuildAssetBundles()
    {
        string assetBundleDirectory = "Assets/AssetBundles";
        if (!Directory.Exists(assetBundleDirectory))
        {
            //if there is no folder/directory of this name, then creating one using this piece of code.          
            Directory.CreateDirectory(assetBundleDirectory);
        }
        //Used to build the asset bundles and save them in that particular folder.
        BuildPipeline.BuildAssetBundles(assetBundleDirectory, BuildAssetBundleOptions.None, BuildTarget.Android);
    }
}