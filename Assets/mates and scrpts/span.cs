using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class span : MonoBehaviour
{
    public GameObject water,Elec,Fire;

    public void spawnWater()
    {
        Instantiate(water, new Vector3(0, 1, 0), new Quaternion(0, 0, 0, 0));
        FindObjectOfType<gamemanager>().gameStarted=true;
    }
    public void spawnELec()
    {
        Instantiate(Elec, new Vector3(0, 1, 0), new Quaternion(0, 0, 0, 0));
        FindObjectOfType<gamemanager>().gameStarted = true;
    }
    public void spawnFire()
    {
        Instantiate(Fire, new Vector3(0, 1, 0), new Quaternion(0, 0, 0, 0));
        FindObjectOfType<gamemanager>().gameStarted = true;
    }

}
