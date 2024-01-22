using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEditor.Rendering;
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
    private bool GemActivate = false;
    public GameObject imagen;
    public TextMeshProUGUI dialogo;
    public GameObject[] ListaCamaras;
    //public Ca�on ca�on;
    //public Proyectiles proyectil;
    public MeshRenderer myMeshRenderer;
    //public Movimiento myMovimiento;
    public GameObject Jugador1;
    public GameObject Jugador2;
    private float timeText = 5f;

    public Power poder;

    private void Start()
    {

        ListaCamaras[0].gameObject.SetActive(true);// camaraplayer1
        ListaCamaras[1].gameObject.SetActive(true);//camaraplayer2
        ListaCamaras[2].gameObject.SetActive(false);//canonplayer1
        ListaCamaras[3].gameObject.SetActive(false);//canonplayer2
        ListaCamaras[4].gameObject.SetActive(false);//power
        ListaCamaras[5].gameObject.SetActive(false);//powerPl2

        poder.enabled = false;

        Jugador1 = Jugador1.gameObject;
        Jugador2 = Jugador2.gameObject;
        desactivar();
 


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
            GemActivate = true;
        }

        if (GemActivate == true)
        {
            BarraDeVida.fillAmount = 100 / VidaMaxima;
            Star.fillAmount = 100 / VidaMaxima;

            
            if (Player1 == true)
            {
                if (collision.gameObject.CompareTag("deteccion"))
                {
                    
                    poder.enabled = true;

                    myMeshRenderer.enabled = false;


                    gameObject.transform.position = new Vector3(-9.76000023f, 3.0539999f, 8.14000034f);

                    myMeshRenderer.enabled = true;


                    ListaCamaras[4].gameObject.SetActive(true);
                    ListaCamaras[0].gameObject.SetActive(false);
                    activar();


                    Invoke("desactivar", timeText);




                }
                if (collision.gameObject.CompareTag("Floor3"))
                {
                    ListaCamaras[0].gameObject.SetActive(true);
                    ListaCamaras[2].gameObject.SetActive(false);
                    desactivar();
      
                }
            }
            if (Player2 == true)
            {
                if (collision.gameObject.CompareTag("deteccion"))
                {
                    poder.enabled = true;
;
                    myMeshRenderer.enabled = false;


                    gameObject.transform.position = new Vector3(-9.76000023f, 3.0539999f, 8.14000034f);

                    myMeshRenderer.enabled = true;


                    ListaCamaras[5].gameObject.SetActive(true);
                    ListaCamaras[1].gameObject.SetActive(false);

                    activar();

                    Invoke("desactivar",timeText);


                    

                }
                if (collision.gameObject.CompareTag("Floor3"))
                {
                    ListaCamaras[1].gameObject.SetActive(true);
                    ListaCamaras[3].gameObject.SetActive(false);
                    
                    desactivar() ;
                }
            }
        }


        if(GemActivate == false)
        {
            if (Player2 == true)
            {
                if (Jugador2)
                {
                    if (collision.gameObject.CompareTag("deteccion") || collision.gameObject.CompareTag("Ca�on"))
                    {
                        
                        myMeshRenderer.enabled = false;


                        Jugador2.transform.position = new Vector3(-9.68999958f, 3.0539999f, 5.03100014f);

                        myMeshRenderer.enabled = true;


                        ListaCamaras[3].gameObject.SetActive(true);
                        ListaCamaras[1].gameObject.SetActive(false);

                        
                        
                    }
                    if (collision.gameObject.CompareTag("Floor3"))
                    {
                        ListaCamaras[1].gameObject.SetActive(true);
                        ListaCamaras[3].gameObject.SetActive(false);
                       
                    }
                }
            }
            if (Player1 == true )
            {
 
                if (Jugador1)
                {
                    if (collision.gameObject.CompareTag("deteccion") || collision.gameObject.CompareTag("Ca�on"))
                    {

                        myMeshRenderer.enabled = false;

                        Jugador1.transform.position = new Vector3(-10.0500002f, 3.03999996f, 11.3400002f);
                        

                        myMeshRenderer.enabled = true;


                        ListaCamaras[2].gameObject.SetActive(true);
                        ListaCamaras[0].gameObject.SetActive(false);

                        
                        //activar();
                    }

                    if (collision.gameObject.CompareTag("Floor3"))
                    {
                        ListaCamaras[0].gameObject.SetActive(true);
                        ListaCamaras[2].gameObject.SetActive(false);

                        
                        
                    }
                }
            }


        }

 
    }
    public void activar()
    {
        dialogo.gameObject.SetActive(true);
        imagen.gameObject.SetActive(true);
    }
    public void desactivar()
    {
          dialogo.gameObject.SetActive(false);

          imagen.gameObject.SetActive(false);
    }

}
