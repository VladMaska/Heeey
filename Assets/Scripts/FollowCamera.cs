using UnityEngine;

using NaughtyAttributes;

public class FollowCamera : MonoBehaviour {
    
    [HorizontalLine]
    [SerializeField] private Transform target;
    [HorizontalLine]
    [SerializeField] private Vector3 offset;
    [Space]
    [SerializeField] private float dumping;

    /*––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––*/

    private Vector3 _velocity = Vector3.zero;
    private Transform _targetTransform;

    /*––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––*/

    private void Start() => _targetTransform = target.GetComponent<Transform>();

    private void LateUpdate(){
        
        var targetPosition = _targetTransform.position + offset;
        var newPosition = Vector3.Lerp( transform.position, targetPosition, dumping * Time.deltaTime) ;
        transform.position = newPosition;
        
    }
    
}