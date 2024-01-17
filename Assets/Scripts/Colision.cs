using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Colision : MonoBehaviour
{
    public GameObject imagen;
    public TextMeshProUGUI[] dialogo;
    public GameObject[] ListaCamaras;
  
    public MeshRenderer myMeshRenderer;
    public Movimiento myMovimiento;


   


    private void Start()
    { 
       
        ListaCamaras[0].gameObject.SetActive(true);
        ListaCamaras[1].gameObject.SetActive(false);
        desactivar();


    }


    void OnCollisionEnter(Collision collision)
    {


        if (collision.gameObject.CompareTag("deteccion"))
        {

            myMeshRenderer.enabled = false;

            gameObject.transform.position = new Vector3(-10.0500002f, 3.03999996f, 11.3400002f);

            myMeshRenderer.enabled = true;


            ListaCamaras[1].gameObject.SetActive(true);
            ListaCamaras[0].gameObject.SetActive(false);

            myMovimiento.enabled = false;

            activar();

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
