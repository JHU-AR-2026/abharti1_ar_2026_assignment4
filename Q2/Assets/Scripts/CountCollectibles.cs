using UnityEngine;

public class CountCollectibles : MonoBehaviour
{
    private int totalPossible = 6;
    private int counter = 0;
    public GameObject PowerUp;
   
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        PowerUp.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CollectItem()
    {
        counter++;
        //Debug.Log("counter upped: " + counter);
        if (counter >= totalPossible)
        {
            PowerUp.SetActive(true);
        }
    }

}
