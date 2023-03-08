using UnityEngine;
using NaughtyAttributes;

public class Build : MonoBehaviour {

    [HorizontalLine]
    [ShowAssetPreview]
    [SerializeField] private Texture2D map;

    [SerializeField] private Vector2Int pos;

    [SerializeField] private Color blockColor;

    [SerializeField] private MapGeneratorData mgd;
    
    [HorizontalLine]
    
    [ShowAssetPreview]
    [SerializeField] private GameObject block;

    [Button("Test")]
    private void TestBuild() => Run( pos.x, pos.y );

    private void Run( int posX, int posY ){
        
        blockColor = GetColor( posX, posY );
        print( CheckBlock( posX, posY ) );

        block = mgd
            .BlockData()[Color.white]
            .GetBlock()[ "1" ];
        
        Instantiate( block, Vector3.zero, Quaternion.identity );

    }

    private string CheckBlock( int posX, int posY ){

        // var blockID = new char[4]; // create a char array with size of 4

        var blockID = "";

        if ( GetColor( posX, posY ).a > 0 )
            
            // Check each block around the current block
            for ( var i = 1; i <= 4; i++ ){

                switch ( i ){

                    /* left block */
                    case 1:

                        if ( posX - 1 >= 0 && GetColor( posX - 1, posY ) == blockColor )
                            blockID += $"{i}";

                        break;

                    /* top block */
                    case 2:

                        if ( posY + 1 < map.height && GetColor( posX, posY + 1 ) == blockColor )
                            blockID += $"{i}";

                        break;

                    /* bottom block */
                    case 3:

                        if ( posY - 1 >= 0 && GetColor( posX, posY - 1 ) == blockColor )
                            blockID += $"{i}";

                        break;

                        /* right block */
                    case 4:

                        if ( posX + 1 < map.width && GetColor( posX + 1, posY ) == blockColor )
                            blockID += $"{i}";

                        break;

                }

            }
        
        else
            blockID = "null";
                
        return ( blockID == "" ) ? "0" : blockID;
        
    }

    private Color GetColor( int posX, int posY ){ return map.GetPixel( posX, posY ); }

}