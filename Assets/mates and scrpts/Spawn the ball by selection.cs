using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawntheballbyselection : MonoBehaviour
{
    public GameObject water, Elec, Fire;
    Transform A;

    public void spawnWater()
    {
        Instantiate(water, new Vector3(0, 1, 0),new Quaternion(0,0,0,0) );
    }
    public void spawnELec()
    {
        Instantiate(Elec, new Vector3(0, 1, 0), new Quaternion(0, 0, 0, 0));
    }
    public void spawnFire()
    {
        Instantiate(Fire, new Vector3(0, 1, 0), new Quaternion(0, 0, 0, 0));
    }

}
