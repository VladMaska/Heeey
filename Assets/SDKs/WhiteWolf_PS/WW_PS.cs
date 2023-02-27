using UnityEngine;
using UnityEngine.InputSystem;

#if UNITY_EDITOR
using UnityEditor;
#endif

using System.Collections;
using System.Collections.Generic;

namespace WhiteWolf.PS {

    public class WW_PS : MonoBehaviour {

        /*====================================================================*/

        public static bool debug = false;
        public static bool work = false;

        /*====================================================================*/

        public static void DebugMode( bool _debug = true ) => debug = _debug;

        public static string DebugInfo(){ return $"{debug}"; }
        public static string WorkInfo(){ return Gamepad.all.Count != 0 ? "『 Connected 』" : "『 Not connected 』"; }
        public static string CountInfo() { return $"{Gamepad.all.Count}"; }

        /*====================================================================*/

#if UNITY_EDITOR

        public static void TestConnect(){

            if ( Gamepad.all.Count == 0 ){

                work = false;
                Debug.Log("<color=#ff0000>『 Please connect controller 』</color>");
                EditorApplication.isPaused = true;

            }
            else if ( Gamepad.all.Count > 0 && !work ){

                work = true;
                Debug.Log("<color=#00ff00>『 Сontroller connected 』</color>");

            }

        }

#endif
        
        public static void Connect(){

            if ( Gamepad.all.Count == 0 && work ){

                work = false;
                Debug.Log("<color=#ff0000>『 Please connect controller 』</color>");

            }
            else if ( Gamepad.all.Count > 0 && !work ){

                work = true;
                Debug.Log("<color=#00ff00>『 Сontroller connected 』</color>");

            }

        }

    }

}