using UnityEngine;
using System.Collections.Generic;

using NaughtyAttributes;
using Unity.VisualScripting;

[CreateAssetMenu( menuName = "Data/Animation" )]
public class AnimationData : ScriptableObject {

    [HorizontalLine]
    
    public float interval;

    [HorizontalLine]
    
    [ShowAssetPreview]
    public Sprite[] frames;

}