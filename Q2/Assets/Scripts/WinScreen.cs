using UnityEngine;

public class WinScreen : MonoBehaviour
{
    public GameObject winText;
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
            winText.SetActive(true);
            other.gameObject.SetActive(false);
        }
    }
}
