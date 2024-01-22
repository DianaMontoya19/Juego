using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Power : MonoBehaviour
{
    public GameObject power;
    public Transform posicion;
   

    // Update is called once per frame
    void Update()
    {
        presionar();
    }
    public void presionar()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {

            Instantiate(power, posicion);

        }
    }
}
