using UnityEngine;

public class Collision : MonoBehaviour
{
    private void OnCollisionEnter(Collision other) 
    {
        Debug.Log("Something hit me!");
    }
}
