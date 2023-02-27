# if UNITY_EDITOR

using UnityEngine;
using UnityEditor;

using WhiteWolf.PS;

public class WW_PS_UI : EditorWindow {

    bool _debug = false;

    /*------------------------------------------------------------------------*/

    /*------------------------------------------------------------------------*/

    [MenuItem("White Wolf/PS/PS Info UI")]
    public static void ShowWindow() => GetWindow<WW_PS_UI>( "White Wolf PS Info UI" );

    public static void HorizontalLine ( Color color ) {

        EditorGUILayout.Space( 7.5f );

        GUIStyle horizontalLine;
        horizontalLine = new GUIStyle();
        horizontalLine.normal.background = EditorGUIUtility.whiteTexture;
        horizontalLine.margin = new RectOffset( 0, 0, 4, 4 );
        horizontalLine.fixedHeight = 1;

        var c = GUI.color;
        GUI.color = color;
        GUILayout.Box( GUIContent.none, horizontalLine );
        GUI.color = c;

        EditorGUILayout.Space( 2.5f );

    }

    void OnGUI (){

        EditorGUILayout.Space();

        GUILayout.Label( "INFO", EditorStyles.boldLabel );
        EditorGUILayout.DelayedTextField( "Controllers: ", WW_PS.CountInfo() );
        EditorGUILayout.TextField( "Work: ", WW_PS.WorkInfo() );

        HorizontalLine( Color.gray );

        _debug = EditorGUILayout.Toggle( "Debug", _debug );
        WW_PS.DebugMode( _debug );

        this.Repaint();

    }

}

#endif