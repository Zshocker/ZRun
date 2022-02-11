
using UnityEngine;

public class followPlayer : MonoBehaviour
{
    public bool rot=false;
   GameObject player=null;
    public Vector3 offset;

   
    void Update()
    {
        if (player == null)
        {
            player = FindObjectOfType<gamemanager>().Findplayer();
        }
        if (player != null)
        {
            transform.position = player.transform.position + offset;
        }
        
    }
}
