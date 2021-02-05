using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="New ImportConfig", menuName ="ImportConfig")]
public class ImportSettingsConfig : ScriptableObject
{   
    [Header("Texture Import Settings")]
    public int MaxTextureSize;

    [Range(0,16)]
    public int AnsiotropicLevel;



    
    
   
}
