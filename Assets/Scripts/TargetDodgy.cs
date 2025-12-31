using Unity.VisualScripting;
using UnityEngine;

public class TargetDodgy : MonoBehaviour
{
    [SerializeField] Transform player;
    [SerializeField] float moveSpeed;
    Vector3 playerPosition;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerPosition = player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        MoveToPlayer();

    }

    void MoveToPlayer()
    {
        transform.position = Vector3.MoveTowards(transform.position, playerPosition, moveSpeed * Time.deltaTime);
    }
}
