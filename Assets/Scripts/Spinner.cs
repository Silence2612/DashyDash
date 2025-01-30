using UnityEngine;

public class Spinner : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    [SerializeField] float X_value = 0.5f;
    [SerializeField] float Y_value = 0.0f;
    [SerializeField] float Z_value = 0.0f;

    [SerializeField] float SpinSpeed = 200.0f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Rotator();
    }

    void Rotator(){
        transform.Rotate
        (
            X_value*Time.deltaTime*SpinSpeed,
            Y_value*Time.deltaTime*SpinSpeed,
            Z_value*Time.deltaTime*SpinSpeed
        );
    }
}
