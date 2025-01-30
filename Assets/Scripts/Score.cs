using UnityEngine;

public class Score : MonoBehaviour
{
    int bumped = 0;
    private void OnCollisionEnter(Collision other) 
    {
       
        if(other.gameObject.tag == "Hit")
        {
            Debug.Log("You have already bumped into it");
        }
        else
        {
            bumped++;
            Debug.Log("Current Score " +  bumped);
        }
        

    }
}
