using UnityEngine;
using Color = UnityEngine.Color;

using NaughtyAttributes;

namespace WhiteWolf.LevelGenerator {

    public class WW_LevelGenerator : MonoBehaviour {

        [Space]
        [Range( 0, 1 )]
        [SerializeField] private float n;

        [Space]
        
        [SerializeField] private AreaType areaType;
        
        [SerializeField] private Color areaColor;
        [Space]
        
        [SerializeField] private Transform level;
        [SerializeField] private MapGeneratorData  mapData;

        /*––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––*/

        private float _posX, _posY;
        private enum AreaType {
            
            None,
            Block,
            Border
            
        }

        private GameObject _block;

        /*––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––*/

        private void Start(){
            
            _posX = -( ( mapData.map.width / 2 ) * n );
            _posY = -( ( mapData.map.height / 2 ) * n );
            
            Generator();

        }

        /*––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––*/

        private void Generator(){

            for ( var x=0; x < mapData.map.width; x++ )
                
                for ( var y=0; y < mapData.map.height; y++ )
                    
                    GenerateTile( x, y );

        }

        private void GenerateTile( int x, int y ){

            var pixelColor = mapData.map.GetPixel( x, y );

            if ( pixelColor.a == 0 ){ return; }

            _block = mapData
                .BlockData()[ pixelColor ]
                .GetBlock()[ CheckBlock( x, y, pixelColor ) ];

            var pos = new Vector2( _posX + ( x * n ), _posY + ( y * n ) );

            var obj = Instantiate( _block, Vector3.zero, Quaternion.identity, level );
            obj.transform.localPosition = pos;
            obj.name = _block.name;

        }
        
        private string CheckBlock( int posX, int posY, Color blockColor ){

            // var blockID = new char[4]; // create a char array with size of 4

            var blockID = "";

            if ( GetColor( posX, posY ).a > 0 )
            
                // Check each block around the current block
                for ( var i = 1; i <= 4; i++ ){

                    switch ( i ){
                        
                        /* top block */
                        case 1:

                            if ( posY + 1 < mapData.map.height && GetColor( posX, posY + 1 ) == blockColor )
                                blockID += $"{i}";

                            break;
                        
                        /* right block */
                        case 2:

                            if ( posX + 1 < mapData.map.width && GetColor( posX + 1, posY ) == blockColor )
                                blockID += $"{i}";

                            break;

                        /* bottom block */
                        case 3:

                            if ( posY - 1 >= 0 && GetColor( posX, posY - 1 ) == blockColor )
                                blockID += $"{i}";

                            break;
                        
                        /* left block */
                        case 4:

                            if ( posX - 1 >= 0 && GetColor( posX - 1, posY ) == blockColor )
                                blockID += $"{i}";

                            break;

                    }

                }
        
            else
                blockID = "null";
                
            return ( blockID == "" ) ? "0" : blockID;
        
        }
        
        private Color GetColor( int posX, int posY ){ return mapData.map.GetPixel( posX, posY ); }

        /*––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––*/

        private void OnDrawGizmos(){
            
            var size = new Vector3(

                mapData.map.width * n,
                mapData.map.height * n,
                0

            );
            
            Gizmos.color = areaColor;

            if ( !level )
                level = this.gameObject.transform;
            
            if ( areaType != AreaType.None )

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
        
        /*––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––*/

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