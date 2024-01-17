using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moneda : MonoBehaviour
{
    // public PhysicMaterial myMaterial;
    //public GameObject Jugador;
    public GameObject Coin;
    public GameObject Coin2;
    public GameObject gem;
    // public bool moneda=false;
    // public GameObject Jugador2;
    public Material material1;
    public GameObject Jugador;

    public string name;
    private bool player2 = false, player21= false;
    void OnCollisionEnter(Collision collision)
    {
        Renderer rend = Jugador.GetComponent<Renderer>();
        if (collision.gameObject.name == ("Jugador"))
        {
            switch (name)
            {
                case "Coin":
                    
                    Debug.Log("monedaRecogida");
                   
                    Destroy(Coin.gameObject);
                    break;


                case "gem":
                   
                    Debug.Log("monedaRecogida" );

                    Destroy(gem.gameObject);
                    break;

            }
        }
        if(collision.gameObject.name == ("Jugador2"))
        {
            switch (name)
            {
                case "Coin2":
                  
                    Debug.Log("monedaRecogida" );

                    Destroy(Coin2.gameObject);
                    player2 = true;
                    
                    break;

                case "gem":
                   
                    Debug.Log("monedaRecogida" );

                    Destroy(gem.gameObject);
                    player21 = true;
                    
                    break;
            }
           if(player2 == true && player21 == true)
            {
                rend.material = material1;
            }
                  
                
                
            
        }

        //if (collision.gameObject.name ==("Jugador") || collision.gameObject.name == ("Jugador2"))
        //{
        //    Desaparecer();
        //    moneda = true;
        //}


    }


    
}
