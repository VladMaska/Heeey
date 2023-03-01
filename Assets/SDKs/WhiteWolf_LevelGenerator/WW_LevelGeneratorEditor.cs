using UnityEngine;
using UnityEditor;

namespace WhiteWolf.LevelGenerator {

	[CustomEditor(typeof(WW_LevelGenerator))]
	public class WW_LevelGeneratorEditor : Editor {

		public override void OnInspectorGUI(){

			base.OnInspectorGUI();

			var generator = (WW_LevelGenerator) target;
			
			/*––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––*/

			GUILayout.BeginHorizontal();

			if ( GUILayout.Button( "New" ) )
				generator.New();

			GUILayout.EndHorizontal();
			
			/*––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––*/
			
			GUILayout.BeginHorizontal();
			
			if ( GUILayout.Button( "Reset" ) )
				generator.Reset();
			
			GUILayout.EndHorizontal();
			
			/*––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––*/

		}

	}
	
}
