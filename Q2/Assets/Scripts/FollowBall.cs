using UnityEngine;

public class FollowBall : MonoBehaviour
{
    public Transform ballTransform; // Reference to the ball's transform
    private Vector3 offset; // Offset between the camera and the ball
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        offset = transform.position - ballTransform.position; // Calculate the initial offset
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = ballTransform.position + offset; // Follow the ball with the calculated offset
    }
}
