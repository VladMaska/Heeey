using UnityEngine;
using UnityEngine.InputSystem;
using System.Collections;
using System.Collections.Generic;

namespace WhiteWolf.PS.Right {

    public class RightStick : WW_PS {

        /*====================================================================*/

        public class XY {

            public static float X( int gamepad = 0 ){

                if ( work )
                    return Gamepad.all[ gamepad ].rightStick.x.ReadValue();

                return 0.0f;

            }

            public static float Y( int gamepad = 0 ){

                if ( work )
                    return Gamepad.all[ gamepad ].rightStick.y.ReadValue();

                return 0.0f;

            }

        }

        /*====================================================================*/

        public class Value {

            public static float Up( int gamepad = 0 ){

                if ( work )
                    return Gamepad.all[ gamepad ].rightStick.up.ReadValue();

                return 0.0f;

            }

            public static float Left( int gamepad = 0 ){

                if ( work )
                    return Gamepad.all[ gamepad ].rightStick.left.ReadValue();

                return 0.0f;

            }

            public static float Down( int gamepad = 0 ){

                if ( work )
                    return Gamepad.all[ gamepad ].rightStick.down.ReadValue();

                return 0.0f;

            }

            public static float Right( int gamepad = 0 ){

                if ( work )
                    return Gamepad.all[ gamepad ].rightStick.right.ReadValue();

                return 0.0f;

            }

        }

        /*====================================================================*/

        public static bool Up( int gamepad = 0 ){

            if ( work )
                return Gamepad.all[ gamepad ].rightStick.up.isPressed;

            return false;

        }

        public static bool Left( int gamepad = 0 ){

            if ( work )
                return Gamepad.all[ gamepad ].rightStick.left.isPressed;

            return false;
        }

        public static bool Down( int gamepad = 0 ){

            return Gamepad.all[gamepad].rightStick.down.isPressed;
        }

        public static bool Right( int gamepad = 0 ){

            return Gamepad.all[gamepad].rightStick.right.isPressed;

        }

    }

}