using UnityEngine;
using System.Collections.Generic;

using NaughtyAttributes;
using Unity.VisualScripting;

[CreateAssetMenu( menuName = "Data/Animation" )]
public class AnimationData : ScriptableObject {

    [HorizontalLine]
    
    public string key;
    
    [HorizontalLine]
    
    public float interval;

    [Space( 20 )]
    
    [ShowAssetPreview]
    public Sprite[] frames;

}