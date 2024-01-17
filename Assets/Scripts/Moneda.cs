using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moneda : MonoBehaviour
{
    // public PhysicMaterial myMaterial;
    //public GameObject Jugador;
    public GameObject Coin;
   // public GameObject Jugador2;
    void OnCollisionEnter(Collision collision)
    {
       // Renderer rend = Jugador.GetComponent<Renderer>();

        if (collision.gameObject.name ==("Jugador") || collision.gameObject.name == ("Jugador2"))
        {
            Desaparecer();
           
        }
 

    }
    void Desaparecer()
    {
        Destroy(Coin.gameObject);
    }

    
}
