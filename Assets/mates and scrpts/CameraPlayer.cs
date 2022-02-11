
using UnityEngine;

public class CameraPlayer : MonoBehaviour
{
    
    public Quaternion RO;
   GameObject player=null;
    public Vector3 offset;
    private void Start()
    {
        transform.rotation = RO;
    }

    void Update()
    {
        if (player == null)
        {
            player = FindObjectOfType<gamemanager>().Findplayer();
        }
        if (player != null)
        {
            Vector3 A= player.transform.position + offset;
            A.x = 0;
            transform.position = A;
            
        }  
    }
}
