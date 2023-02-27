using UnityEngine;
using System.Collections;

using NaughtyAttributes;
using WhiteWolf.PS;
using WhiteWolf.PS.Left;

public class PlayerMove : MonoBehaviour {
    
    [HorizontalLine]
    
    [SerializeField] private PlayerSettings settings;
    [Label("DataBase")] [SerializeField] private AnimationsDB aDB;

    /*––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––*/
    
    private Transform _transform;
    private Heeey.Animation _animation;
    
    private float _speed;

    #region PC

    private KeyCode _left;
    private KeyCode _right;

    #endregion

    /*––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––*/
    
    private void Start(){

        _transform = this.gameObject.GetComponent<Transform>();
        _animation = this.gameObject.GetComponent<Heeey.Animation>();
        
        _speed = settings.playerSpeed;

        #region PC

        _left = settings.Control()["Left"];
        _right = settings.Control()["Right"];

        #endregion
        
    }

    private void Update(){
        
        WW_PS.Connect();
        
        if ( !WW_PS.work && settings.controlType == "PS" )
            settings.controlType = "PC";

        MovingAnimation();

        if ( settings.controlType == "PC" ){
            
            if ( Input.GetKey( _left ) && !Input.GetKey( _right ) )
                Left();

            if ( !Input.GetKey( _left ) && Input.GetKey( _right ) )
                Right();

        }
        
        if ( settings.controlType == "PS" && WW_PS.work ){
            
            if ( LeftStick.Left() )
                Left();

            if ( LeftStick.Right() )
                Right();
            
        }
        
    }
    
    /*––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––*/
    
    private void MovingAnimation(){

        switch ( settings.controlType ){
            
            case "PC":
                
                if ( Input.GetKey( _left ) || Input.GetKey( _right ) )
                    _animation.animationData = aDB.GetData()[ "MOVE" ];
                    
                else
                    _animation.animationData = aDB.GetData()["IDLE"];
                
                
                break;
            
            case "PS":
                
                if ( LeftStick.Left() || LeftStick.Right() )
                    _animation.animationData = aDB.GetData()[ "MOVE" ];
        
                else
                    _animation.animationData = aDB.GetData()["IDLE"];
                
                break;

        }

    }
    
    /*––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––*/

    private void Left(){

        transform.eulerAngles = new Vector3 ( 0, 0, 0 );
        
        var left = Vector3.left * _speed;
        var timeSinceLastFrame = Time.deltaTime;
        var translation = left * timeSinceLastFrame;
            
        _transform.Translate( translation );
        
    }
    
    private void Right(){

        transform.eulerAngles = new Vector3 ( 0, 180, 0 );
        
        var right = Vector3.left * _speed;
        var timeSinceLastFrame = Time.deltaTime;
        var translation = right * timeSinceLastFrame;
            
        _transform.Translate( translation );
        
    }
    
}