using UnityEngine;
using System.Collections.Generic;

using NaughtyAttributes;

[CreateAssetMenu( menuName = "Data/Animations DB" )]
public class AnimationsDB : ScriptableObject {

    [HorizontalLine]
    public Animations[] animations;

    /*––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––*/

    public Dictionary<string, AnimationData> GetData(){
        
        var toReturn = new Dictionary<string, AnimationData>();
    
        foreach ( var entry in animations )
            toReturn.TryAdd( entry.key, entry.animationData );
    
        return toReturn;
        
    }

}

/*––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––*/

[System.Serializable]
public struct Animations {

    [HorizontalLine]
    
    public string key;
    [Space]
    public AnimationData animationData;

}