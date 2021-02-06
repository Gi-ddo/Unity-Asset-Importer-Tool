using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class AudioClipConfig : AssetPostprocessor
{
    void OnPreprocessAudio()
    {
        if (assetPath.Contains("SampleAssets"))
        {
            AudioImporter audioImporter = (AudioImporter)assetImporter;
            audioImporter.forceToMono = true;
            
        }
    }
}
