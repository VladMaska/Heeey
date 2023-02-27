# if UNITY_EDITOR

using UnityEngine;
using UnityEditor;

using WhiteWolf.PS.Buttons;
using WhiteWolf.PS.Arrows;
// using WhiteWolf.PS.PS;

public class PS_ButtonsArrows : EditorWindow {

    /*------------------------------------------------------------------------*/

    /*------------------------------------------------------------------------*/

    [MenuItem("White Wolf/PS/Buttons and Arrows")]
    public static void ShowWindow() => GetWindow<PS_ButtonsArrows>( "Buttons and Arrows Info" );

    void OnGUI (){

        EditorGUILayout.Space();

        GUILayout.Label( "Buttons", EditorStyles.boldLabel );
        EditorGUILayout.TextField( "✖ | Cross: ", Buttons.Pressing.Cross() ? "『 Clicked 』" : "『 Not Clicked 』" );
        EditorGUILayout.TextField( "■ | Square: ", Buttons.Pressing.Square() ? "『 Clicked 』" : "『 Not Clicked 』" );
        EditorGUILayout.TextField( "▲ | Triagle: ", Buttons.Pressing.Triagle() ? "『 Clicked 』" : "『 Not Clicked 』" );
        EditorGUILayout.TextField( "● | Circle: ", Buttons.Pressing.Circle() ? "『 Clicked 』" : "『 Not Clicked 』" );

        WW_PS_UI.HorizontalLine( Color.gray );

        GUILayout.Label( "Arrows", EditorStyles.boldLabel );
        EditorGUILayout.TextField( "↑ | Up: ", Arrows.Press.Up() ? "『 Clicked 』" : "『 Not Clicked 』" );
        EditorGUILayout.TextField( "← | Left: ", Arrows.Press.Left() ? "『 Clicked 』" : "『 Not Clicked 』" );
        EditorGUILayout.TextField( "↓ | Down: ", Arrows.Press.Down() ? "『 Clicked 』" : "『 Not Clicked 』" );
        EditorGUILayout.TextField( "→ | Right: ", Arrows.Press.Right() ? "『 Clicked 』" : "『 Not Clicked 』" );

        // WW_PS_UI.HorizontalLine( Color.gray );
        //
        // GUILayout.Label( "Share | Option", EditorStyles.boldLabel );
        // EditorGUILayout.TextField( "Share: ", PSB.Press.ShareB() ? "『 Clicked 』" : "『 Not Clicked 』" );
        // EditorGUILayout.TextField( "Option: ", PSB.Press.OptionB() ? "『 Clicked 』" : "『 Not Clicked 』" );

        this.Repaint();

    }

}

#endif