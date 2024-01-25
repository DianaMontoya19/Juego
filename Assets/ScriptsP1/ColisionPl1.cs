using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ColisionPl1 : MonoBehaviour
{
    //public GameObject imagen;
    //public TextMeshProUGUI[] dialogo;
    //public GameObject[] ListaCamaras;


    public MeshRenderer myMeshRenderer;
   
    public GameObject Jugador1;

    public Detections vida;



    void OnCollisionEnter(Collision collision)
    {
     
        if (collision.gameObject.CompareTag("Jugador"))
        {
           

            myMeshRenderer.enabled = false;

            Jugador1.transform.position = new Vector3(5.42999983f, 3.23000002f, 10.6599998f);


            myMeshRenderer.enabled = true;

            //for(int i = 0; i < 100; i++)
            //{
            //    vida.BarraDeVida.fillAmount = i  +  75 / vida.VidaMaxima;
            //}
         
  
            



        }

    }



}
