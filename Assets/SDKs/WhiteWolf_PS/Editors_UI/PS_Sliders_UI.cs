# if UNITY_EDITOR

using UnityEngine;
using UnityEditor;

using WhiteWolf.PS.Left;
using WhiteWolf.PS.L;
using WhiteWolf.PS.Right;
using WhiteWolf.PS.R;

public class PS_Sliders_UI : EditorWindow {

    /*------------------------------------------------------------------------*/

    /*------------------------------------------------------------------------*/

    [MenuItem("White Wolf/PS/Sliders Info UI")]
    public static void ShowWindow() => GetWindow<PS_Sliders_UI>( "Sliders Info UI" );

    void OnGUI (){

        EditorGUILayout.Space();

        GUILayout.Label( "Left Slider", EditorStyles.boldLabel );
        EditorGUILayout.TextField( "X: ", $"{LeftStick.XY.X()}" );
        EditorGUILayout.TextField( "Y: ", $"{LeftStick.XY.Y()}" );
        EditorGUILayout.TextField( "L3: ", L.L3() ? "Clicked" : "Not Clicked" );

        EditorGUILayout.Space( 10 );

        //GUILayout.Label( "UP | LEFT | DOWN | RIGHT", EditorStyles.boldLabel );
        EditorGUILayout.Space( 2.5f );
        EditorGUILayout.TextField( "UP: ", $"{LeftStick.Up()}" );
        EditorGUILayout.TextField( "LEFT: ", $"{LeftStick.Left()}" );
        EditorGUILayout.TextField( "DOWN: ", $"{LeftStick.Down()}" );
        EditorGUILayout.TextField( "RIGHT: ", $"{LeftStick.Right()}" );

        WW_PS_UI.HorizontalLine( Color.grey );

        GUILayout.Label( "Right Slider", EditorStyles.boldLabel );
        EditorGUILayout.TextField( "X: ", $"{RightStick.XY.X()}" );
        EditorGUILayout.TextField( "Y: ", $"{RightStick.XY.Y()}" );
        EditorGUILayout.TextField( "R3: ", R.R3() ? "Clicked" : "Not Clicked" );

        EditorGUILayout.Space( 10 );

        //GUILayout.Label( "UP | LEFT | DOWN | RIGHT", EditorStyles.boldLabel );
        EditorGUILayout.Space( 2.5f );
        EditorGUILayout.TextField( "UP: ", $"{RightStick.Up()}" );
        EditorGUILayout.TextField( "LEFT: ", $"{RightStick.Left()}" );
        EditorGUILayout.TextField( "DOWN: ", $"{RightStick.Down()}" );
        EditorGUILayout.TextField( "RIGHT: ", $"{RightStick.Right()}" );

        this.Repaint();

    }

}

#endif