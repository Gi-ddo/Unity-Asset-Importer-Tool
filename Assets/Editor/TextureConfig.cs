using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class TextureConfig : AssetPostprocessor
{
   public ImportSettingsConfig imptSetting;
    void OnPostprocessTexture(Texture2D texture)
    {

        string path = assetPath.ToLower();
        bool isInPath = path.IndexOf("/SampleAssets/") != -1;


        if (isInPath)
        {
            TextureImporter textImpt = (TextureImporter)assetImporter;
           // textImpt.anisoLevel = imptSetting.AnsiotropicLevel;
            textImpt.textureType = TextureImporterType.Sprite;
        }

    }
}
