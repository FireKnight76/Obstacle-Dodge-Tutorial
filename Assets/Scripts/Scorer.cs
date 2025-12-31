using Unity.VisualScripting;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    int hits = 0;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag != "Hit" && collision.gameObject.tag != "Untaggable")
        {
            hits++;
            Debug.Log($"You have hit {hits} objects");
        }
    }
}
