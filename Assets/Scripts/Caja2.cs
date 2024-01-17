using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Caja2 : MonoBehaviour
{
    public GameObject caja2;



    void Update()
    {
        transform.position = caja2.transform.position + new Vector3(0f, 0.112f, 0f);

    }
 
}
