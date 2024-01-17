using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Move : MonoBehaviour
{
    
    public float velocidad;
    public float fuerzaSalto = 5f;
    public Vector3 gravedad = new Vector3(0f, 9.8f, 0f);
    public Vector3 gravedad2 = new Vector3(0f, -9.8f, 0f);
    bool enter = false;
    bool salir = false;
    private bool puedoSaltar;
    public LayerMask layerSuelo;
    private Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();



    }
    public void FixedUpdate()
    {

        float movimientoHor = Input.GetAxisRaw("Horizontal1");
        float xSpeed = movimientoHor * velocidad;
        float movimientoVer = Input.GetAxisRaw("Vertical1");
        float zSpeed = movimientoVer * velocidad;

        Vector3 movimiento = new Vector3(zSpeed, rb.velocity.y, -xSpeed);


        rb.velocity = movimiento;

    }
        void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab) && puedoSaltar)
        {
            Vector3 movimientoFuerza = Vector3.up * fuerzaSalto;
            rb.AddForce(movimientoFuerza, ForceMode.Impulse);
        }
        puedoSaltar = Physics.Raycast(transform.position, Vector3.down, 1f, layerSuelo);

    }
    void OnCollisionEnter(Collision collision)
    {

        while (enter == false)
        {
            if (collision.gameObject.CompareTag("salto"))
            {
                rb.useGravity = false;
                rb.AddForce(gravedad, ForceMode.Acceleration);



            }

            enter = true;
            salir = true;

        }
        while (salir == true)
        {

            if (collision.gameObject.CompareTag("salio"))
            {
                rb.useGravity = true;
                // rb.AddForce(gravedad2, ForceMode.Acceleration);

            }

            salir = false;
            enter = false;
        }

   









    }
 
}
