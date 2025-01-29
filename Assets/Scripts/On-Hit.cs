using UnityEngine;

public class CollisionHandler : MonoBehaviour // ✅ Changed class name
{
    void OnCollisionEnter(Collision collision) // Now correctly refers to Unity's Collision type
    {
        Debug.Log("Collision detected with: " + collision.gameObject.name);
    }
}
