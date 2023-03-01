using System;
using NaughtyAttributes;
using UnityEngine;
using Color = UnityEngine.Color;
using Random = UnityEngine.Random;

namespace WhiteWolf.LevelGenerator {

    [System.Serializable]
    public class Elements {

        public string name;

        [Space]

        public Color color;
        
        [ShowAssetPreview]
        public GameObject[] element;

    }

    public class WW_LevelGenerator : MonoBehaviour {

        [Space]
        [SerializeField] private float n;

        [Space]
        
        [SerializeField] private AreaType areaType;
        
        [SerializeField] private Color areaColor;
        [Space]
        
        [SerializeField] private Transform level;
        [SerializeField] private MapGeneratorData mapData;
        // [SerializeField] private Texture2D map;
        // [SerializeField] private Elements[] elements;

        /*––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––*/

        private float _posX, _posY;
        private enum AreaType {
            
            Block,
            Border
            
        }

        /*––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––*/

        private void Start(){
            
            _posX = -( ( mapData.map.width / 2 ) * n );
            _posY = -( ( mapData.map.height / 2 ) * n );
            
            Generator();

        }

        /*––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––*/

        private void Generator(){

            for ( var x=0; x < mapData.map.width; x++ )
                
                for ( var y=0; y < mapData.map.height; y++ )
                    
                    GenerateTile( x, y );

        }

        private void GenerateTile( int x, int y ){

            var pixelColor = mapData.map.GetPixel( x, y );

            if ( pixelColor.a == 0 ){ return;  }

            foreach ( var el in mapData.elements ) {

                if ( el.color.Equals( pixelColor ) ){

                    var pos = new Vector2( _posX + ( x * n ), _posY + ( y * n ) );

                    var r = Random.Range( 0, el.element.Length );

                    var obj = Instantiate( el.element[ r ], Vector3.zero, Quaternion.identity, level );
                    obj.transform.localPosition = pos;
                    obj.name = el.name;

                }

            }

        }

        /*––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––*/

        private void OnDrawGizmos(){
            
            var size = new Vector3(

                mapData.map.width * n,
                mapData.map.height * n,
                0

            );
            
            Gizmos.color = areaColor;

            if ( !level )
                level = this.gameObject.transform;

            switch ( areaType ){
                
                case AreaType.Block:
                    
                    Gizmos.DrawCube( transform.position, size );
                    
                    break;
                
                case AreaType.Border:
                    
                    areaColor = new Color( areaColor.r, areaColor.b, areaColor.g, 255/255f );
                    Gizmos.DrawWireCube( transform.position, size );
                    
                    break;
                
            }

        }
        
        /*––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––*/

        public void Reset(){

            for( var i = transform.childCount - 1; i >= 0; i-- )
                DestroyImmediate( transform.GetChild( i ).gameObject );

        }
        
        public void New(){
            
            _posX = -( ( mapData.map.width / 2 ) * n );
            _posY = -( ( mapData.map.height / 2 ) * n );
            
            if ( transform.childCount != 0 )
                Reset();
            
            Generator();
            
        }
        
    }

}