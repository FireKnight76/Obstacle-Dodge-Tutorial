using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class TriggerProjectile : MonoBehaviour
{
    [SerializeField] GameObject projectileObject;
    Vector3 playerPosition;

    private void Awake()
    {
    }


    private void OnTriggerEnter(Collider other)
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player");

        int summonCount = Random.Range(0, 6);

        playerPosition = player.transform.position;

        if (other.gameObject.tag == "Player")
        {
            for (int i = 0; i < summonCount; i++)
            {
                Instantiate(
                    projectileObject, 
                    new Vector3(
                        Random.Range(playerPosition.x - 5, playerPosition.x + 5),
                        8f, 
                        Random.Range(playerPosition.z - 5, playerPosition.z + 5))
                    , Quaternion.identity);
            }
        }
    }

}
