using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="New ImportConfig", menuName ="ImportConfig")]
public class ImportSettingsConfig : ScriptableObject
{
    public int MaxTextureSize;

    [Range(0,9)]
    public int AnsiotropicLevel;
    
    
   
}
