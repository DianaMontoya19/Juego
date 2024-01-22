using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Colision : MonoBehaviour
{
    //public GameObject imagen;
    //public TextMeshProUGUI[] dialogo;
    //public GameObject[] ListaCamaras;


    public MeshRenderer[] myMeshRenderer;
   
    public GameObject Jugador1;
    public GameObject Jugador2;
    Moneda vida;



    void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.CompareTag("Jugador"))
        {
           // vida.BarraDeVida.fillAmount =  vida.VidaMaxima/25;

            myMeshRenderer[0].enabled = false;

            Jugador1.transform.position = new Vector3(5.42999983f, 3.23000002f, 10.6599998f);


            myMeshRenderer[0].enabled = true;



        }
        if (collision.gameObject.CompareTag("Jugador2"))
        {

            myMeshRenderer[1].enabled = false;


            Jugador2.transform.position = new Vector3(5.42999983f, 3.23000002f, 6.1500001f);

            myMeshRenderer[1].enabled = true;



        }
    }



}
