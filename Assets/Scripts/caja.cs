using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class caja : MonoBehaviour
{
    public GameObject Caja;
 
    void Update()
    {
        transform.position = Caja.transform.position + new Vector3(0f, 0.8f, 0f);
        
    }
}
