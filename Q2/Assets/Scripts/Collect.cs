using UnityEngine;

public class Collect : MonoBehaviour
{
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
            // Destroy the cube when the player collides with it
            // Destroy(gameObject);
            other.GetComponent<CountCollectibles>().CollectItem();
            gameObject.SetActive(false); // Deactivate the cube instead of destroying it
        }
    }
}


