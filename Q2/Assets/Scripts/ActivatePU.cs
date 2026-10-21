using UnityEngine;

public class ActivatePU : MonoBehaviour
{
    public GameObject text;
    public GameObject trapdoor;
    public GameObject normalWall;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            trapdoor.SetActive(true);
            normalWall.SetActive(false); 
            other.GetComponent<Renderer>().material = gameObject.GetComponent<Renderer>().material;
            other.GetComponent<MoveBall>().speed -= 5;
            gameObject.SetActive(false);
            text.SetActive(true);
        }
    }
}
