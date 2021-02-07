using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

//creating an apply button for scriptable object
[CustomEditor(typeof(ImportSettingsConfig))]
public class ApplyButton : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        ImportSettingsConfig temp = (ImportSettingsConfig)target;

        //Applying changes when button is pressed
        if (GUILayout.Button("Apply", GUILayout.Height(20), GUILayout.Width(60)))
        {
            Debug.Log("Import Settings Applied");
            TextureConfig.ansioLevel = temp.AnsiotropicLevel;
            TextureConfig.maxTexSize = (TextureSizes)(int)temp.MaxTextureSize;
            AudioClipConfig._sampleRate = temp.SampleRate;
            AudioClipConfig._compressionFormat = temp.CompressFormat;
            AudioClipConfig._loadType = temp.LoadType;
        }
    } 
}

