
using UnityEngine;

public class wining : MonoBehaviour
{
    public gamemanager gameManager;
    public Playermovement pL=null;

    private void Update()
    {
        gameManager = FindObjectOfType<gamemanager>();
        pL = FindObjectOfType<Playermovement>();
    }
    
    void OnTriggerEnter(Collider other)
    {
        gameManager.levelwining();
        pL.enabled = false;
    }
}