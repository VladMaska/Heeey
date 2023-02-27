# if UNITY_EDITOR

using UnityEngine;
using UnityEditor;

using WhiteWolf.PS.L;
using WhiteWolf.PS.R;

public class PS_LR_UI : EditorWindow {

    /*------------------------------------------------------------------------*/

    /*------------------------------------------------------------------------*/

    [MenuItem("White Wolf/PS/L and R Info UI")]
    public static void ShowWindow() => GetWindow<PS_LR_UI>( "L1 L2 and R1 R2 Info UI" );

    void OnGUI (){

        EditorGUILayout.Space();

        GUILayout.Label( "Left", EditorStyles.boldLabel );
        EditorGUILayout.TextField( "L1: ", L.L1() ? "『 Clicked 』" : "『 Not Clicked 』");
        EditorGUILayout.TextField( "L2: ", $"{ L.Value.L2() }" );

        WW_PS_UI.HorizontalLine( Color.grey );

        GUILayout.Label( "Right", EditorStyles.boldLabel );
        EditorGUILayout.TextField( "R1: ", R.R1() ? "『 Clicked 』" : "『 Not Clicked 』");
        EditorGUILayout.TextField( "R2: ", $"{ R.Value.R2() }" );

        this.Repaint();

    }

}

#endif