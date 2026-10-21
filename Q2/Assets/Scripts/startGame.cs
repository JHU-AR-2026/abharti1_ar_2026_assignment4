using UnityEngine;
using UnityEngine.UI;

public class startGame : MonoBehaviour
{  
    public GameObject ball;
    public Rigidbody rb;
    public MoveBall mb; 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = ball.GetComponent<Rigidbody>();
        mb = ball.GetComponent<MoveBall>();

        rb.useGravity = false;
        mb.enabled = false;

        GetComponent<Button>().onClick.AddListener(BeginGame);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void BeginGame()
    {
        rb.useGravity = true;
        mb.enabled = true;
        gameObject.SetActive(false);
    }
}
