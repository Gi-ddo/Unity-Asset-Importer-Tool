using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;


[CreateAssetMenu(fileName = "New ImportConfig", menuName = "ImportConfig")]
public  class ImportSettingsConfig : ScriptableObject
{
    [Header("Texture Import Settings")]


    [Range(0, 16)]
    public  int AnsiotropicLevel;



    [Header("Audio Clip Import Settings")]
    public AudioSampleRateSetting SampleRate;

    public AudioCompressionFormat CompressFormat;

    public AudioClipLoadType LoadType;


  



}
