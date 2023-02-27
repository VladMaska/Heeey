using UnityEngine;
using UnityEngine.InputSystem;
using System.Collections;
using System.Collections.Generic;

namespace WhiteWolf.PS.Arrows {

    public class Arrows : WW_PS {

        public class Press {

            // ↑
            public static bool Up( int gamepad = 0 ){

                if ( work )

                    if ( Gamepad.all[ gamepad ].dpad.up.isPressed ){

                        if ( debug ) Debug.Log( "↑ | UpArrow pressed!");
                        return true;

                    }

                return false;

            }

            // ←
            public static bool Left( int gamepad = 0 ){

                if ( work )

                    if ( Gamepad.all[ gamepad ].dpad.left.isPressed ){

                        if ( debug ) Debug.Log( "← | LeftArrow pressed!");
                        return true;

                    }

                return false;

            }

            // ↓
            public static bool Down( int gamepad = 0 ){

                if ( work )

                    if ( Gamepad.all[ gamepad ].dpad.down.isPressed ){

                        if ( debug ) Debug.Log( "↓ | DownArrow pressed!");
                        return true;

                    }

                return false;

            }

            // →
            public static bool Right( int gamepad = 0 ){

                if ( work )

                    if ( Gamepad.all[ gamepad ].dpad.right.isPressed ){

                        if ( debug ) Debug.Log( "→ | RightArrow pressed!");
                        return true;

                    }

                return false;

            }

        }

        /*====================================================================*/

        public static bool Up( int gamepad = 0 ){

            if ( work )

                if ( Gamepad.all[ gamepad ].dpad.up.wasPressedThisFrame ){

                    if ( debug ) Debug.Log( "↑ | UpArrow pressed!");
                    return true;

                }
                else if ( Gamepad.all[ gamepad ].dpad.up.isPressed ){

                    if ( debug ) Debug.Log( "↑ | UpArrow pressed!");
                    return true;

                }

            return false;

        }

        public static bool Left( int gamepad = 0 ){

            if ( work )

                if ( Gamepad.all[ gamepad ].dpad.left.wasPressedThisFrame ){

                    if ( debug ) Debug.Log( "← | LeftArrow pressed!");
                    return true;

                }
                else if ( Gamepad.all[ gamepad ].dpad.left.isPressed ){

                    if ( debug ) Debug.Log( "← | LeftArrow pressed!");
                    return true;

                }

            return false;

        }

        public static bool Down( int gamepad = 0 ){

            if ( work )

                if ( Gamepad.all[ gamepad ].dpad.down.wasPressedThisFrame ){

                    if ( debug ) Debug.Log( "↓ | DownArrow pressed!");
                    return true;

                }
                else if ( Gamepad.all[ gamepad ].dpad.down.isPressed ){

                    if ( debug ) Debug.Log( "↓ | DownArrow pressed!");
                    return true;

                }

            return false;

        }

        public static bool Right( int gamepad = 0 ){

            if ( work )

                if ( Gamepad.all[ gamepad ].dpad.right.wasPressedThisFrame ){

                    if ( debug ) Debug.Log( "→ | RightArrow pressed!");
                    return true;

                }
                else if ( Gamepad.all[ gamepad ].dpad.right.isPressed ){

                    if ( debug ) Debug.Log( "→ | RightArrow pressed!");
                    return true;

                }

            return false;

        }


    }

}