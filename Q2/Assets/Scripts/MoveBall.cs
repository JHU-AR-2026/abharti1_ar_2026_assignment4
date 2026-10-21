using UnityEngine;
using TMPro;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class MoveBall : MonoBehaviour
{
    private InputAction moveAction;
    private InputAction jumpAction;
    private Rigidbody rb;
    public float speed = 5f;
    public float jumpForce = 10f;
    private bool isGrounded = false;
    private bool jumpQueued = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        moveAction = InputSystem.actions.FindAction("Move");
        jumpAction = InputSystem.actions.FindAction("Jump");
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isGrounded && jumpAction.triggered)
        {
            jumpQueued = true;
        }   
    }
    private void FixedUpdate()
    {
        if (jumpQueued)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            jumpQueued = false;
            isGrounded = false;
        }
        Vector2 moveValue = moveAction.ReadValue<Vector2>();
        Vector3 movement = new Vector3(-moveValue.x, 0.0f, -moveValue.y);
        rb.AddForce(movement * speed);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Floor"))
        {
            isGrounded = true;
        }
    }
}
