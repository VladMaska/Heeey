using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;

namespace WhiteWolf.PS.R {

    public class R : WW_PS {

        /*====================================================================*/

        public class Value {

            public static float R2( int gamepad = 0 ){

                if ( work )
                    return Gamepad.all[ gamepad ].rightTrigger.ReadValue();

                return 0.0f;

            }

        }

        /*====================================================================*/

        public static bool R1( int gamepad = 0 ){

            if ( work )

                if ( Gamepad.all[ gamepad ].rightShoulder.wasPressedThisFrame ){

                    if ( debug ) Debug.Log( "R1 pressed!" );
                    return true;

                } else if ( Gamepad.all[gamepad].rightShoulder.isPressed ){

                    if ( debug ) Debug.Log("R1 pressed!");
                    return true;

                }

            return false;

        }

        public static bool R2( int gamepad = 0 ){

            if ( work )

                if ( Gamepad.all[ gamepad ].rightTrigger.wasPressedThisFrame ){

                    if ( debug ) Debug.Log( "R2 pressed!" );
                    return true;

                } else if ( Gamepad.all[gamepad].rightTrigger.isPressed ){

                    if ( debug ) Debug.Log("R2 pressed!");
                    return true;

                }

            return false;

        }

        public static bool R3( int gamepad = 0 ){

            if ( work )

                if ( Gamepad.all[ gamepad ].rightStickButton.wasPressedThisFrame ){

                    if ( debug ) Debug.Log( "R3 pressed!" );
                    return true;

                } else if ( Gamepad.all[gamepad].rightStickButton.isPressed ){

                    if ( debug ) Debug.Log("R3 pressed!");
                    return true;

                }

            return false;

        }

    }

}