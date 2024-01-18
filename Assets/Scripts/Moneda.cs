using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class Moneda : MonoBehaviour
{
    // public PhysicMaterial myMaterial;
    //public GameObject Jugador;
    public GameObject Coin;
    public GameObject Coin2;
    public GameObject Gem;
    public Image BarraDeVida;
    public Image Star;
    //public Material material1;
    //public GameObject Jugador;
    private float VidaMaxima = 100;
    
    //private int conta;
    

    public bool Player1 = false;
    public bool Player2 = false;
 
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Coin"))
        {

            Destroy(Coin.gameObject);

            BarraDeVida.fillAmount = 50 / VidaMaxima;
            Star.fillAmount = 50 / VidaMaxima;
            Player1 = true;
        }
        if (collision.gameObject.CompareTag("Coin2"))
        {

            Destroy(Coin2.gameObject);

            BarraDeVida.fillAmount = 50 / VidaMaxima;
            Star.fillAmount = 50 / VidaMaxima;
            Player2 = true;
        }
        if (Player1 == true || Player2 == true)
        {
            if (collision.gameObject.CompareTag("Gem"))
            {
                Destroy(Gem.gameObject);
                BarraDeVida.fillAmount = 100 / VidaMaxima;
                Star.fillAmount = 100 / VidaMaxima;
            }
        }








        //if (collision.gameObject.name == ("gem"))
        //{
        //    conta = 2;
        //    Destroy(Gem.gameObject);
        //}

        //Renderer rend = Jugador.GetComponent<Renderer>();
        //if (collision.gameObject.name == ("Jugador"))
        //{
        //    switch (name)
        //    {
        //        case "Coin":

        //            Debug.Log("monedaRecogida");

        //            Desaparecer();
        //            break;


        //        case "gem":

        //            Debug.Log("monedaRecogida" );

        //            Desaparecer();
        //            break;

        //    }
        //}
        //if(collision.gameObject.name == ("Jugador2"))
        //{
        //    switch (name)
        //    {
        //        case "Coin2":

        //            Debug.Log("monedaRecogida" );
        //            Desaparecer();

        //            player2 = true;
        //            BarraDeVida.fillAmount = 50 / VidaMaxima;
        //            Star.fillAmount = 50 / VidaMaxima;
        //          //  conta = 1;
        //            break;

        //        case "gem":

        //            Debug.Log("monedaRecogida" );


        //            Desaparecer();

        //            player21 = true;
        //            BarraDeVida.fillAmount = 50 / VidaMaxima;
        //            Star.fillAmount = 50 / VidaMaxima;
        //            conta = 2;

        //            break;
        //    }
        //   if(conta ==2)
        //    {
        //        rend.material = material1;
        //    }




        //}



    }



    
}
