using UnityEngine;

public class Score : MonoBehaviour
{
    int bumped = 0;
    private void OnCollisionEnter(Collision other) {
        bumped++;
        Debug.Log("You have bumped into smth a lot of times: " +  bumped);
    }
}
