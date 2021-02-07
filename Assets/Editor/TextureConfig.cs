using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

// reference for texture sizes
public enum TextureSizes
{
    _32 = 32,
    _64 = 64,
    _128 = 128,
    _256 = 256,
    _512 = 512,
    _1024 = 1024,
    _2048 = 2048,
    _4096 = 4096,
    _8192 = 8192

}
public class TextureConfig : AssetPostprocessor
{
    // reference variables for apply button script

    public static int ansioLevel;
    public static TextureSizes maxTexSize;


    // runs everytime an texture asset is imported
    void OnPreprocessTexture()
    {

        //Finds asset in SampleAssets folder
        if (assetPath.Contains("SampleAssets"))
        {
            // accessing texture importer functionality to apply to assets
            TextureImporter textureImporter = (TextureImporter)assetImporter;

            textureImporter.anisoLevel = ansioLevel;
            textureImporter.maxTextureSize = (int)maxTexSize;
        }
    }
}
