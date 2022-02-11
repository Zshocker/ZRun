
using UnityEngine;
using UnityEngine.SceneManagement;


public class Playermovement : MonoBehaviour
{
    float xPosition;
    public Rigidbody rbp;
    float forwardForce = 4000f;
    public float jump = 500f, gravityHelper = 1800f;
    float sideways = 8f;
    swipes S;
    int lane = 0;
    
    bool move = false,T=true;
    
    void Start()
    {
        lane = 0;
        if (this.tag == "Plazma") { sideways = 12f; forwardForce = 4500f; }
        else if (this.tag == "Magma") { sideways = 10f; forwardForce = 4250f; }
        S = GetComponent<swipes>();
        xPosition = rbp.position.x;
    }


    void Update()
    {

        T = true;
        Vector3 pos = rbp.position;
        pos.x = Mathf.MoveTowards(pos.x, xPosition, sideways * Time.deltaTime);
        rbp.position = pos;

        if (S.SwipeUp) move = true;
        else if (S.SwipeDown) move = false;
        if ((Input.GetKeyDown("d")||S.SwipeRight)&&T)

        {
            lane++;
            if (lane > 2) lane = 2;
            else { xPosition += 3; }

            //ToRight
            
            T = false;

        }
        if ((Input.GetKeyDown("a") || S.SwipeLeft)&&T)

        {
            lane--;
            if (lane < -2) lane = -2;
            else xPosition -= 3;

            //Toleft

            T = false;
        }
        if (move)

        {
            rbp.AddForce(0, 0, forwardForce * Time.deltaTime);


        }
        if (transform.position.y > 1) { rbp.AddForce(0, -gravityHelper * Time.deltaTime, 0); }
        if (rbp.position.y < -1f)
        {
            FindObjectOfType<gamemanager>().Endgame();
        }
       

    }
    
    public void Fly()
    {

        rbp.AddForce(0, jump * Time.deltaTime, 0, ForceMode.VelocityChange);

    }



}