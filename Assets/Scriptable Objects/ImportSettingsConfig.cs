using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

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
[CreateAssetMenu(fileName = "New ImportConfig", menuName = "ImportConfig")]
public  class ImportSettingsConfig : ScriptableObject
{
   
    // Setting up properties for Texture import Settings
    [Header("Texture Import Settings")]

    [SerializeField]
    private TextureSizes textureSizes;
    public TextureSizes MaxTextureSize
    {
        get
        {
            return textureSizes;
        }

        set
        {
            textureSizes = value;
        }
    }


    [SerializeField]
    [Range(0, 16)]
    private int _ansioLevel;
    public int AnsiotropicLevel
    {
        get
        {
            return _ansioLevel;
        }

        set
        {
            _ansioLevel = value;
        }
    }

    // Setting up properties for Audio Clip import Settings

    [Header("Audio Clip Import Settings")]

    [SerializeField]
    private AudioSampleRateSetting _sampleRate;

    public AudioSampleRateSetting SampleRate
    {
        get
        {
            return _sampleRate;
        }
        set
        {
            _sampleRate = value;
        }
    }

    [SerializeField]
    private AudioCompressionFormat _compressionFormat;
    public AudioCompressionFormat CompressFormat
    {
        get
        {
            return _compressionFormat;
        }

        set
        {
            _compressionFormat = value;
        }
    }
    [SerializeField]
    private AudioClipLoadType _loadType;

    public AudioClipLoadType LoadType
    {
        get
        {
            return _loadType;
        }
        set
        {
            _loadType = value;
        }
    }

}
