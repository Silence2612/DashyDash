using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
     float X_value = Input.GetAxis("Horizontal");
     float Y_value = 0.0f;
     float Z_value = Input.GetAxis("Vertical");;

        transform.Translate(X_value , Y_value , Z_value );
    }
}
