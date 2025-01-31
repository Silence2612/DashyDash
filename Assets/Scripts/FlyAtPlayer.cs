using Unity.VisualScripting;
using UnityEngine;

public class FlyAtPlayer : MonoBehaviour
{
    [SerializeField] float FlySpeed = 40f;
    [SerializeField] Transform PlayerTransform;
    Vector3 PlayerPosition;
    void Start()
    {
        PlayerPosition = PlayerTransform.position;
    }

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position , PlayerPosition , Time.deltaTime*FlySpeed);
        DestroyWhenReached();
    }

    void DestroyWhenReached(){
        if(transform.position == PlayerPosition){
            Destroy(gameObject); 
        }

    }
}
