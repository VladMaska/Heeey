using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;

namespace WhiteWolf.PS.L {

    public class L : WW_PS {

        /*====================================================================*/

        public class Value {

            public static float L2( int gamepad = 0 ){

                if ( work )
                    return Gamepad.all[ gamepad ].leftTrigger.ReadValue();

                return 0.0f;

            }

        }

        /*====================================================================*/

        public static bool L1( int gamepad = 0 ){

            if ( work )

                if ( Gamepad.all[ gamepad ].leftShoulder.wasPressedThisFrame ){

                    if ( debug ) Debug.Log( "L1 pressed!" );
                    return true;

                } else if ( Gamepad.all[gamepad].leftShoulder.isPressed ){

                    if ( debug ) Debug.Log("L1 pressed!");
                    return true;

                }

            return false;

        }

        public static bool L2( int gamepad = 0 ){

            if ( work )

                if ( Gamepad.all[ gamepad ].leftTrigger.wasPressedThisFrame ){

                    if ( debug ) Debug.Log( "L2 pressed!" );
                    return true;

                } else if ( Gamepad.all[gamepad].leftTrigger.isPressed ){

                    if ( debug ) Debug.Log("L2 pressed!");
                    return true;

                }

            return false;

        }

        public static bool L3( int gamepad = 0 ){

            if ( work )

                if ( Gamepad.all[ gamepad ].leftStickButton.wasPressedThisFrame ){

                    if ( debug ) Debug.Log( "L3 pressed!" );
                    return true;

                } else if ( Gamepad.all[gamepad].leftStickButton.isPressed ){

                    if ( debug ) Debug.Log("L3 pressed!");
                    return true;

                }

            return false;

        }

    }

}