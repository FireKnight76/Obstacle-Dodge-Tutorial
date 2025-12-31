using UnityEngine;

public class DodgyBehaviour : MonoBehaviour
{
    [SerializeField] float dodgySpeed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    void MovePlayer()
    {
        float moveX = Input.GetAxis("Horizontal") * Time.deltaTime * dodgySpeed;
        float moveZ = Input.GetAxis("Vertical") * Time.deltaTime * dodgySpeed;

        transform.Translate(moveX, 0, moveZ, Space.World);
    }
}
