using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class gamemanager : MonoBehaviour
{
    public float waiting=4f;
    bool gameEnded=false;
    public bool gameStarted = false;
    public GameObject levelwonUI;
    GameObject[] obs;
    GameObject player=null;
    
    public GameObject Findplayer()
    {

        GameObject P=null;
       
       
            P = GameObject.FindGameObjectWithTag("Water");
            if (P != null) return P;
            P = GameObject.FindGameObjectWithTag("Plazma");
            if (P != null) return P;
            P = GameObject.FindGameObjectWithTag("Magma");
            if (P == null) Debug.Log("player not found");
        
        return P;
    }
    //to disable obsticale collider of the same type as player
    public void disable()
    {
       
            player = Findplayer();
            string tag;
            tag = player.tag + "-Obsticale";
            obs = GameObject.FindGameObjectsWithTag(tag);
            foreach (GameObject O in obs)
            {
                O.GetComponent<BoxCollider>().enabled = false;
            }
      
    }
    private void Update()
    {
        bool Set = true;
        if (gameStarted)
        {
            if (Findplayer()!=null && Set )
            {
                disable();
                Set = false;
            }
        }
    }





    public void Endgame()
    {
       


        if (gameEnded == false)
        {
            gameEnded = true;
            Invoke("restart", waiting);


        }




     }
    public void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
           

    }

    public void levelwining()
    {
        levelwonUI.SetActive(true);

    }
    public void Nextlevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }
    public void levelLoad(string l)
    {
        string Level = "level"+l;
        SceneManager.LoadScene(Level);

    }
    public void levelLoadByName(string l)
    {
        
        SceneManager.LoadScene(l);

    }
}
