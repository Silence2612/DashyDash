using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    [SerializeField] float MoveSpeed = 10;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

     float X_value = Input.GetAxis("Horizontal")*Time.deltaTime*MoveSpeed;
     float Y_value = 0.0f;
     float Z_value = Input.GetAxis("Vertical")*Time.deltaTime*MoveSpeed;

        transform.Translate(X_value , Y_value , Z_value );
    }
}
