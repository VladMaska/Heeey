using UnityEngine;

using NaughtyAttributes;

namespace Heeey {
    
    public class Animation : MonoBehaviour {

        [HorizontalLine]
        public AnimationData animationData;

        public bool mod;

        /*––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––*/

        private SpriteRenderer _sr;

        private float _time;
        private int _f;

        /*––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––*/

        private void Start(){
            
            _sr = GetComponent<SpriteRenderer>();

        }

        private void Update(){
            
            if ( animationData.frames.Length == 1 ){
                
                _time = 0;
                _sr.sprite = animationData.frames[ 0 ];
                
                return;
                
            }

            _time += Time.deltaTime;
            
            if ( _time > animationData.interval ){
                
                _f = ( _f + 1 ) % animationData.frames.Length;
                
                if ( _sr.sprite != animationData.frames[ _f ] ){
                    
                    NewFrame();
                }
                
            }

        }

        /*––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––*/

        private void NewFrame(){
            
            _sr.sprite = animationData.frames[_f];
            _time = 0;
            
        }

    }
    
}