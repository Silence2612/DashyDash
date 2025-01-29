using UnityEngine;

public class CollisionHandler : MonoBehaviour 
{
    void OnCollisionEnter(Collision collision) 
    {
        Debug.Log("Collision detected with: " + collision.gameObject.name);
        GetComponent<MeshRenderer>().material.color = Color.red;
    }
}
