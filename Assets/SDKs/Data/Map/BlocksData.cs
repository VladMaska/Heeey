using System.Collections.Generic;
using UnityEngine;

using NaughtyAttributes;

[CreateAssetMenu( fileName = "Blocks Data", menuName = "Data/Map/Blocks Data" )]
public class BlocksData : ScriptableObject {

    [HorizontalLine]
    public Blocks[] blocks;

    /*––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––*/
    
    public Dictionary<string, GameObject> GetBlock(){
        
        var toReturn = new Dictionary<string, GameObject>();
    
        foreach ( var entry in blocks )
            toReturn.TryAdd( entry.id, entry.block );
    
        return toReturn;
        
    }

}

[System.Serializable]
public class Blocks {

    public string id;

    [Space]

    [ShowAssetPreview]
    public GameObject block;

}