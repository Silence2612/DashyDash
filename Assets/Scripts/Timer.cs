using UnityEngine;
using System.Collections;

public class Timer : MonoBehaviour
{

    [SerializeField] float WaitTime = 3.0f;

    MeshRenderer MyMeshRenderer;
    Rigidbody MyRigidBody;
    void Start()
    {
        MyMeshRenderer = GetComponent<MeshRenderer>();
        MyRigidBody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if(Time.time < WaitTime)
        {
            MyMeshRenderer.enabled = false;
            MyRigidBody.useGravity = false;
        }
        else
        {
            MyMeshRenderer.enabled = true;
            MyRigidBody.useGravity = true;
        }
    }
}
