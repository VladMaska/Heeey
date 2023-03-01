using System;
using UnityEngine;
using System.IO;

using NaughtyAttributes;
using SimpleJSON;

namespace Heeey.Mod.Animation {

    public class AnimationModSystem : MonoBehaviour {

        [HorizontalLine] [SerializeField] private string id;

        [HorizontalLine] public AnimationData[] animationData;

        // [ResizableTextArea]
        // [SerializeField] private string jsonText;

        [Button]
        private void StartLoad() => GetData( $"{id}" );

        /*––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––*/

        private void Start() => GetData( $"{id}" );

        /*––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––*/

        private void GetData( string id ){

            var path = $"{Application.persistentDataPath}/Test";

            var jsonString = File.ReadAllText($"{path}/animations.json");
            // jsonText = jsonString;

            var json = (JSONObject) JSON.Parse(jsonString);

            foreach ( var t in animationData ){
                
                var key = t.key;
                var animJson = json[id][key];

                t.frames = new Sprite[animJson["frames"].Count];

                for ( var j = 0; j < animJson["frames"].Count; j++ )
                    t.frames[j] = LoadFrame( path, animJson["frames"].AsArray[j] );
                
                t.interval = animJson["interval"];
                
            }

        }

        private Sprite LoadFrame( string path, string fileName ){

            var filePath = Path.Combine( path, fileName );

            Sprite sprite = null;

            if ( File.Exists( filePath ) ){
                
                var texture = new Texture2D( 2, 2 ){
                    
                    filterMode = FilterMode.Point,
                    wrapMode = TextureWrapMode.Clamp
                    
                };
                
                texture.LoadImage(File.ReadAllBytes(filePath), true);
                // texture.Apply();

                sprite = Sprite.Create( texture, new Rect( 0, 0, texture.width, texture.height ), new Vector2( 0.5f, 0.5f ) );
                sprite.name = fileName;
                
            }
            else
            {
                Debug.LogWarning("File not found: " + filePath);
            }

            return sprite;

        }

    }

}