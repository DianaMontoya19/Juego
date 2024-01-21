using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Colision : MonoBehaviour
{
    public GameObject imagen;
    public TextMeshProUGUI[] dialogo;
    public GameObject[] ListaCamaras;
    public Cañon cañon;
    public Proyectiles proyectil;

    public MeshRenderer myMeshRenderer;
    public Movimiento myMovimiento;
    //public GameObject Jugador1;
    //public GameObject Jugador2;

    bool poder = false;



    private void Awake()
    {


        ListaCamaras[0].gameObject.SetActive(true);// camaraplayer1
        ListaCamaras[1].gameObject.SetActive(true);//camaraplayer2
        ListaCamaras[2].gameObject.SetActive(false);//canonplayer1
        ListaCamaras[3].gameObject.SetActive(false);//canonplayer2
        ListaCamaras[4].gameObject.SetActive(false);//power

        proyectil.enabled = false;
        cañon.enabled = false;

        //Jugador1 = Jugador1.gameObject;
        //Jugador2 = Jugador2.gameObject;
        desactivar();


    }


    void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.CompareTag("Jugador"))
        {

            myMeshRenderer.enabled = false;

            gameObject.transform.position = new Vector3(-10.0500002f, 3.03999996f, 11.3400002f);
 //           Jugador2.transform.position = new Vector3(-9.68999958f, 3.0539999f, 5.03100014f);

            myMeshRenderer.enabled = true;


           // ListaCamaras[2].gameObject.SetActive(true);
            //ListaCamaras[0].gameObject.SetActive(false);

            myMovimiento.enabled = false;
            activar();

        }
        if (collision.gameObject.CompareTag("Jugador2"))
        {

            myMeshRenderer.enabled = false;


            gameObject.transform.position = new Vector3(-9.68999958f, 3.0539999f, 5.03100014f);

            myMeshRenderer.enabled = true;


            ListaCamaras[3].gameObject.SetActive(true);
            ListaCamaras[1].gameObject.SetActive(false);

            myMovimiento.enabled = false;



            activar();

        }

        if (collision.gameObject.CompareTag("pendulo"))
        {
            ListaCamaras[4].gameObject.SetActive(false);
            

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
