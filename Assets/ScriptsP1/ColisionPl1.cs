using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ColisionPl1 : MonoBehaviour
{
    //public GameObject imagen;
    //public TextMeshProUGUI[] dialogo;
    //public GameObject[] ListaCamaras;


    public MeshRenderer[] myMeshRenderer;
   
    public GameObject Jugador1;

    Detections vida;



    void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.CompareTag("Jugador"))
        {
           // vida.BarraDeVida.fillAmount =  vida.VidaMaxima/25;

            myMeshRenderer[0].enabled = false;

            Jugador1.transform.position = new Vector3(5.42999983f, 3.23000002f, 10.6599998f);


            myMeshRenderer[0].enabled = true;



        }

    }



}
