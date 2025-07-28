using UnityEngine;
using UnityEngine.AI;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed = 5f;
    [SerializeField]
    private float mouseSens = 2f;

    private Vector3 moveDirection;
    private float rotationY;

    void Start()
    {
        transform.rotation = Quaternion.Euler(0f, -90f, 0f);
    } 
    void Update()
    {
        MovementHandler();
        RotationHandler();
    }

    private void MovementHandler()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        moveDirection = new Vector3(horizontal, 0f, vertical).normalized;

        transform.Translate(moveDirection * moveSpeed * Time.deltaTime);
    }

    private void RotationHandler()
    {
        float mouseX = Input.GetAxis("Mouse X");
        rotationY += mouseX * mouseSens;

        transform.rotation = Quaternion.Euler(0f, rotationY, 0f);
    }
}
