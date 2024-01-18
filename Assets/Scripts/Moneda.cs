using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Moneda : MonoBehaviour
{ 
    public GameObject Coin;
    public GameObject Coin2;
    public GameObject Gem;
    public Image BarraDeVida;
    public Image Star;
 
    private float VidaMaxima = 100;
    
  
    

    private bool Player1 = false;
    private bool Player2 = false;
    public bool GemActivate = false;

    public GameObject imagen;
    public TextMeshProUGUI[] dialogo;
    public GameObject[] ListaCamaras;

    public MeshRenderer myMeshRenderer;
    public Movimiento myMovimiento;
    public GameObject Jugador1;
    public GameObject Jugador2;

    private void Start()
    {

        ListaCamaras[0].gameObject.SetActive(true);// camaraplayer1
        ListaCamaras[1].gameObject.SetActive(true);//camaraplayer2
        ListaCamaras[2].gameObject.SetActive(false);//canonplayer1
        ListaCamaras[3].gameObject.SetActive(false);//canonplayer2
        ListaCamaras[4].gameObject.SetActive(false);//power

        Jugador1 = Jugador1.gameObject;
        Jugador2 = Jugador2.gameObject;
        desactivar();


    }
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
        if (collision.gameObject.CompareTag("Gem"))
        {

            Destroy(Gem.gameObject);

            BarraDeVida.fillAmount = 50 / VidaMaxima;
            Star.fillAmount = 50 / VidaMaxima;
           // Player2 = true;
        }

        if (Player1 == true || Player2 == true)
        {
            if (collision.gameObject.CompareTag("Gem"))
            {
               
                Destroy(Gem.gameObject);
                BarraDeVida.fillAmount = 100 / VidaMaxima;
                Star.fillAmount = 100 / VidaMaxima;
                GemActivate = true;

            }
            if (GemActivate == true)
            {
                if (collision.gameObject.CompareTag("deteccion"))
                {

                    myMeshRenderer.enabled = false;


                    gameObject.transform.position = new Vector3(-9.76000023f, 3.0539999f, 8.14000034f);

                    myMeshRenderer.enabled = true;


                    ListaCamaras[4].gameObject.SetActive(true);
                    ListaCamaras[0].gameObject.SetActive(false);

                    //  myMovimiento.enabled = false;



                    // activar();

                }
                //GemActivate = false;
            }


        }

        if (GemActivate == false)
        {
            if (collision.gameObject.CompareTag("deteccion"))
            {

                myMeshRenderer.enabled = false;

                Jugador1.transform.position = new Vector3(-10.0500002f, 3.03999996f, 11.3400002f);
                Jugador2.transform.position = new Vector3(-9.68999958f, 3.0539999f, 5.03100014f);

                myMeshRenderer.enabled = true;


                ListaCamaras[2].gameObject.SetActive(true);
                ListaCamaras[0].gameObject.SetActive(false);

                myMovimiento.enabled = false;



                activar();

            }
        }
        if (collision.gameObject.CompareTag("pendulo"))
        {
            ListaCamaras[1].gameObject.SetActive(false);
            ListaCamaras[0].gameObject.SetActive(true);

            myMovimiento.enabled = true;
            desactivar();
        }




    }

    void activar()
    {
        dialogo[0].gameObject.SetActive(true);
        dialogo[1].gameObject.SetActive(true);
        dialogo[2].gameObject.SetActive(true);
        imagen.gameObject.SetActive(true);
    }
    void desactivar()
    {

        dialogo[0].gameObject.SetActive(false);
        dialogo[1].gameObject.SetActive(false);
        dialogo[2].gameObject.SetActive(false);
        imagen.gameObject.SetActive(false);
    }


}
