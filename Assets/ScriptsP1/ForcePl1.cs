using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForcePl1 : MonoBehaviour
{
    public float fuerza = 5f;
    private Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.useGravity = true;

    }


    void OnCollisionEnter(Collision collision)
    {
       if (rb.useGravity)
        {
            if (collision.gameObject.CompareTag("Jugador"))
            {
               
                rb.AddForce(Vector3.forward * fuerza, ForceMode.Force);

            }

        }



    }


}
