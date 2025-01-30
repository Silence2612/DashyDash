using UnityEngine;

public class CollisionHandler : MonoBehaviour 
{
    bool HasBeenHit = false;
    void OnCollisionEnter(Collision other) 
    {
        if(other.gameObject.tag == "Player")
        {
        HasBeenHit = true;
        GetComponent<MeshRenderer>().material.color = Color.red;
        gameObject.tag = "Hit";
        }
    }
}
