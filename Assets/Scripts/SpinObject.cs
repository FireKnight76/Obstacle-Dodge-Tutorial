using UnityEngine;

public class SpinObject : MonoBehaviour
{
    [SerializeField] float rotateX = 0f;
    [SerializeField] float rotationY = 0f;
    [SerializeField] float rotateZ = 0f;

    // Update is called once per frame
    void Update()
    {
        RotateObject();
    }

    void RotateObject()
    {
        transform.Rotate(rotateX, rotationY, rotateZ);
    }
}
