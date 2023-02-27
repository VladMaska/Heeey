using UnityEngine;
using System.Collections.Generic;

using NaughtyAttributes;

[CreateAssetMenu( menuName = "Data/Player Settings" )]
public class PlayerSettings : ScriptableObject {
    
    [HorizontalLine]
    
    [Dropdown("_controlOptions")]
    public string controlType;
    private string[] _controlOptions = new []{ "PC", "PS" };
    
    [HorizontalLine]
    public float playerSpeed;
    public float playerJump;

    [HorizontalLine]
    
    [SerializeField] private PlayerControlSettings[] control;

    /*––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––*/

    public Dictionary<string, KeyCode> Control(){
        
        var toReturn = new Dictionary<string, KeyCode>();
    
        foreach ( var entry in control )
            toReturn.TryAdd( entry.key, entry.keyCode );
    
        return toReturn;
        
    }

}

/*––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––*/

[System.Serializable]
public struct PlayerControlSettings {
    
    public string key; 
    public KeyCode keyCode;
    
}