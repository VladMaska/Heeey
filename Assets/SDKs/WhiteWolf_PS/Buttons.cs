using UnityEngine;
using UnityEngine.InputSystem;
using System.Collections;
using System.Collections.Generic;

#if UNITY_EDITOR
using UnityEditor;
#endif

namespace WhiteWolf.PS.Buttons {

    public class Buttons : WW_PS {

        /*====================================================================*/

        public class Pressing {

            // ✖
            public static bool Cross( int gamepad = 0 ){

                if ( work )

                    if ( Gamepad.all[ gamepad ].buttonSouth.isPressed ){

                        if ( debug ) Debug.Log( "✖ | Cross pressed!" );
                        return true;

                    }

                return false;

            }

            // ■
            public static bool Square( int gamepad = 0 ){

                if ( work )

                    if ( Gamepad.all[ gamepad ].buttonWest.isPressed ){

                        if ( debug ) Debug.Log( "■ | Square pressed!" );
                        return true;

                    }

                return false;

            }

            // ▲
            public static bool Triagle( int gamepad = 0 ){

                if ( work )

                    if ( Gamepad.all[ gamepad ].buttonNorth.isPressed ){

                        if ( debug ) Debug.Log( "▲ | Triagle pressed!");
                        return true;

                    }

                return false;

            }

            // ●
            public static bool Circle( int gamepad = 0 ){

                if ( work )

                    if ( Gamepad.all[ gamepad ].buttonEast.isPressed ){

                        if ( debug ) Debug.Log( "● | Circle pressed!");
                        return true;

                    }

                return false;

            }

        }

        /*====================================================================*/

        // ✖
        public static bool Cross( int gamepad = 0 ){

            if ( work )

                if ( Gamepad.all[ gamepad ].buttonSouth.wasPressedThisFrame ){

                    if ( debug ) Debug.Log( "✖ | Cross pressed!" );
                    return true;

                }
                else if ( Gamepad.all[ gamepad ].buttonSouth.isPressed && !EditorApplication.isPlaying ){

                    if ( debug ) Debug.Log( "✖ | Cross pressed!" );
                    return true;

                }

            return false;

        }

        // ■
        public static bool Square( int gamepad = 0 ){

            if ( work )

                if ( Gamepad.all[ gamepad ].buttonWest.wasPressedThisFrame ){

                    if ( debug ) Debug.Log( "■ | Square pressed!" );
                    return true;

                }
                else if ( Gamepad.all[ gamepad ].buttonWest.isPressed && !EditorApplication.isPlaying ){

                    if ( debug ) Debug.Log( "■ | Square pressed!" );
                    return true;

                }

            return false;

        }

        // ▲
        public static bool Triagle( int gamepad = 0 ){

            if ( work )

                if ( Gamepad.all[ gamepad ].buttonNorth.wasPressedThisFrame ){

                    if ( debug ) Debug.Log( "▲ | Triagle pressed!");
                    return true;

                }
#if UNITY_EDITOR
                else if ( Gamepad.all[ gamepad ].buttonNorth.isPressed && !EditorApplication.isPlaying ){

                    if ( debug ) Debug.Log( "▲ | Triagle pressed!");
                    return true;

                }
#endif

            return false;

        }

        // ●
        public static bool Circle( int gamepad = 0 ){

            if ( work )

                if ( Gamepad.all[ gamepad ].buttonEast.wasPressedThisFrame ){

                    if ( debug ) Debug.Log( "● | Circle pressed!");
                    return true;

                }
                else if ( Gamepad.all[ gamepad ].buttonEast.isPressed && !EditorApplication.isPlaying ){

                    if ( debug ) Debug.Log( "● | Circle pressed!");
                    return true;

                }

            return false;

        }

    }

}