using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEditor.Rendering;
using UnityEngine;
using UnityEngine.UI;

public class Detections : MonoBehaviour
{

    public GameObject Coin;
    public GameObject Gem;
    public Image BarraDeVida;
    public Image Star;

    public float VidaMaxima = 100;
    private bool Player1 = false;
    private bool GemActivate = false;

    public GameObject[] ListaCamaras;
    public MeshRenderer myMeshRenderer;
    public GameObject Jugador1;



    //public Power poder;

    private void Start()
    {

        ListaCamaras[0].gameObject.SetActive(true);// camaraplayer1
        ListaCamaras[1].gameObject.SetActive(false);// Jumpplayer1


        Jugador1 = Jugador1.gameObject;
   
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Coin"))
        {

            Destroy(Coin);

            BarraDeVida.fillAmount = 50 / VidaMaxima;
            Star.fillAmount = 50 / VidaMaxima;
            Player1 = true;
        }

        if (collision.gameObject.CompareTag("Gem"))
        {

            Destroy(Gem.gameObject);
            BarraDeVida.fillAmount = 50 / VidaMaxima;
            Star.fillAmount = 50 / VidaMaxima;
            GemActivate = true;
        }

        if (GemActivate == true && Player1 == true)
        {
            BarraDeVida.fillAmount = 100 / VidaMaxima;
            Star.fillAmount = 100 / VidaMaxima;

            if (collision.gameObject.CompareTag("deteccion") || collision.gameObject.CompareTag("JumpingRea"))
            {

                myMeshRenderer.enabled = false;

                gameObject.transform.position = new Vector3(-9.39000034f, 3.0999999f, 11.2299995f);

                myMeshRenderer.enabled = true;


                ListaCamaras[1].gameObject.SetActive(true);
                ListaCamaras[0].gameObject.SetActive(false);


         

            }


                
            if (collision.gameObject.CompareTag("Floor3"))
              {
                    ListaCamaras[0].gameObject.SetActive(true);
                    ListaCamaras[1].gameObject.SetActive(false);
                    

              }
 
        }
    }


}
