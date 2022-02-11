
using UnityEngine;
using UnityEngine.UI;


public class playerCollision : MonoBehaviour
{
    
    public Playermovement movement ;
    public score scoreText;
    public Animator anim;
    public GameObject splash;
    string TagObsticale;
    Rigidbody RD;
    string[] Type=new string[2];
    public void PlayerDeath()
    {
      
        scoreText = FindObjectOfType<score>();
       RD= GetComponent<Rigidbody>();
        RD.constraints = RigidbodyConstraints.FreezePosition;
        movement.enabled = false;
        scoreText.enabled = false;
        anim.SetBool("Death", true);
        splash.SetActive(true);
        
        FindObjectOfType<gamemanager>().Endgame();
        
    }
    


    private void OnCollisionEnter(Collision collisionInfo)
    {

        TagObsticale = collisionInfo.collider.tag;
        if (TagObsticale == "obsticales" || TagObsticale== "Water-Obsticale"|| TagObsticale == "Magma-Obsticale"|| TagObsticale == "Plazma-Obsticale")
        {
            
            PlayerDeath();
        }
       
        
    }

}
