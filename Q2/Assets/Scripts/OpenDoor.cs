using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    public GameObject winWall1;
    public GameObject winWall2;
    public GameObject winWall3;
    public GameObject winPlatform;
    public GameObject winBubble;
    public GameObject trapdoor;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        winWall1.SetActive(false);
        winWall2.SetActive(false);
        winBubble.SetActive(false);
        winWall3.SetActive(false);
        winPlatform.SetActive(false);
        trapdoor.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            trapdoor.SetActive(false);
            //Debug.Log("hit trapdoor");
            winWall1.SetActive(true);
            winWall2.SetActive(true);
            winBubble.SetActive(true);
            winWall3.SetActive(true);
            winPlatform.SetActive(true);
        }
    }
}
