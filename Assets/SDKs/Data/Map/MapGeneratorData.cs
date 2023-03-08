using UnityEngine;
using System.Collections.Generic;

using NaughtyAttributes;
using WhiteWolf.LevelGenerator;

[CreateAssetMenu( fileName = "Map Data", menuName = "Data/Map/Map Data" )]
public class MapGeneratorData : ScriptableObject {

    [HorizontalLine]
    public string mapName;
    
    [HorizontalLine]
    
    [ShowAssetPreview]
    public Texture2D map;
    [Space(20)]
    public Elements[] elements;
    
    /*––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––*/
    
    // public Dictionary<Color, string> GetColor(){
    //     
    //     var toReturn = new Dictionary<Color, string>();
    //
    //     foreach ( var entry in elements )
    //         toReturn.TryAdd( entry.color, entry.name );
    //
    //     return toReturn;
    //     
    // }

    // public int GetArrayIndex( string indexName ){
    //
    //     for ( var i = 0; i < elements.Length; i++ ){
    //         
    //         if ( indexName == elements[ i ].name )
    //             return i;
    //
    //     }
    //
    //     return -1;
    //     
    // }
    
    // public Dictionary<string, GameObject> GetBlock( string key ){
    //     
    //     var toReturn = new Dictionary<string, GameObject>();
    //
    //     foreach ( var entry in control )
    //         toReturn.TryAdd( entry.key, entry.keyCode );
    //
    //     return toReturn;
    //     
    // }
    
    public Dictionary<Color, BlocksData> BlockData(){
        
        var toReturn = new Dictionary<Color, BlocksData>();
    
        foreach ( var entry in elements )
            toReturn.TryAdd( entry.color, entry.blocks );
    
        return toReturn;
        
    }

}

[System.Serializable]
public class Elements {

    public string name;

    [Space]

    public Color color;
        
    public BlocksData blocks;

}