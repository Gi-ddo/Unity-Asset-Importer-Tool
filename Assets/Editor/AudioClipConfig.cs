using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class AudioClipConfig : AssetPostprocessor
{
    // runs everytime an audio asset is imported


    //Reference variables for apply button script
    public static AudioClipLoadType _loadType;
    public static AudioCompressionFormat _compressionFormat;
    public static AudioSampleRateSetting _sampleRate;
    public static bool _androidOverride;

   public void OnPreprocessAudio()
    {

        //Finds asset in SampleAssets folder
        if (assetPath.Contains("SampleAssets"))
        {

            // accessing audio importer functionality to apply to assets
            AudioImporter audioImporter = (AudioImporter)assetImporter;

            //getting access to audioclip sample settings to be configured
            AudioImporterSampleSettings _sampleSettings = audioImporter.defaultSampleSettings;
            

            _sampleSettings.compressionFormat = _compressionFormat;
            _sampleSettings.loadType = _loadType;
            _sampleSettings.sampleRateSetting = _sampleRate;
            

           
            // Applying all sample settings
            audioImporter.defaultSampleSettings = _sampleSettings;

            if (_androidOverride == true)
            {
                // Platform specific settings
                audioImporter.SetOverrideSampleSettings("Android", _sampleSettings);
            }

        }
    }
}
