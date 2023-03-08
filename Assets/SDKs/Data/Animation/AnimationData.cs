using UnityEngine;
using System.Collections.Generic;

using NaughtyAttributes;
using Unity.VisualScripting;

[CreateAssetMenu( fileName = "Animation",menuName = "Data/Animation/Animation" )]
public class AnimationData : ScriptableObject {

    [HorizontalLine]
    public string key;
    
    [HorizontalLine]
    
    public float interval;

    [Space( 20 )]
    
    [ShowAssetPreview]
    public Sprite[] frames;

}