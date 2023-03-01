using System;
using System.Collections;
using UnityEngine;

using NaughtyAttributes;
using WhiteWolf.PS;
using WhiteWolf.PS.Buttons;

public class PlayerJump : MonoBehaviour {
    
    [HorizontalLine]
    
    [SerializeField] private PlayerSettings settings;

    /*––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––*/
    
    private Transform _transform;
    private Rigidbody2D _rb;

    [SerializeField] private float jumpN, jN;

    /*––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––*/
    
    private void Start(){
        
        WW_PS.Connect();
        
        _transform = this.gameObject.GetComponent<Transform>();
        _rb =  this.gameObject.GetComponent<Rigidbody2D>();

        jN = jumpN;

    }

    private void Update(){

        if ( settings.controlType == "PC" ){
            
            if ( Input.GetKeyDown( settings.Control()["Jump"] ) && jumpN != 0 ){
                
                Jump();
                jumpN--;

            }

        }
        
        if ( settings.controlType == "PS" && WW_PS.work ){
            
            if ( Buttons.Cross() && jumpN != 0 ){
                
                Jump();
                jumpN--;

            }

        }
        
    }
    
    /*––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––*/

    private void Jump() => _rb.AddForce( new Vector2( 0, settings.playerJump ), ForceMode2D.Impulse );

    /*––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––*/

    private void OnCollisionEnter2D( Collision2D other ){

        if ( other.gameObject.CompareTag( "Ground" ) )
            jumpN = jN;

    }

}