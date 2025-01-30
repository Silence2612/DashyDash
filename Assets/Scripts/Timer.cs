using UnityEngine;
using System.Collections;

public class Timer : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float time = 3 - Time.time;
        if(time>0){
            Debug.Log("Dropping in " + time);
        }
        else{
            Debug.Log("Look out");
        }
    }
}
