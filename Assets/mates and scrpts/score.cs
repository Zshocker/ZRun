
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public GameObject player=null;
    public Text scoreText;

   
    void Update()
    {

       
        if (player == null)
        {
            player = FindObjectOfType<gamemanager>().Findplayer();
            
        }

        if (player != null)
        {
            scoreText.text = player.transform.position.z.ToString("0");
        }
        
    }
}
