using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class TextureConfig : AssetPostprocessor
{


    ImportSettingsConfig importConfig = ScriptableObject.CreateInstance<ImportSettingsConfig>();

    void OnPreprocessTexture()
    {
        if (assetPath.Contains("SampleAssets"))
        {
            TextureImporter textureImporter = (TextureImporter)assetImporter;
            //textureImporter.convertToNormalmap = false;
            //textureImporter.textureType = TextureImporterType.Sprite;
            textureImporter.anisoLevel = importConfig.AnsiotropicLevel;
            //textureImporter.maxTextureSize = 
            Debug.Log(importConfig.AnsiotropicLevel);

        }
    }
}
