using UnityEngine;

using NaughtyAttributes;
using WhiteWolf.LevelGenerator;

[CreateAssetMenu( menuName = "Data/Map Generator" )]
public class MapGeneratorData : ScriptableObject {

    [HorizontalLine]
    public string mapName;
    
    [HorizontalLine]
    
    [ShowAssetPreview]
    public Texture2D map;
    [Space(20)]
    public Elements[] elements;

}