using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{

    // Start is called before the first frame update
    ////public GameObject[] Jugador;
    //public string horizontalAxis;
    public string horizontalAxis;
    public string verticalAxis;
    public string SaltoPlayer;


    public float velocidad;
    private Vector3 gravedad = new Vector3(0f, 9.8f, 0f);
    private Vector3 gravedad2 = new Vector3(0f, -9.8f, 0f);
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
       
        

            float movimientoHor = Input.GetAxisRaw(horizontalAxis);
            float xSpeed = movimientoHor * velocidad;
            float movimientoVer = Input.GetAxisRaw(verticalAxis);
            float zSpeed = movimientoVer * velocidad;

            Vector3 movimiento = new Vector3(zSpeed, rb.velocity.y, -xSpeed);


            rb.velocity = movimiento;

        
    }
 

    private void Update()
    {
 
        float salto = Input.GetAxisRaw(SaltoPlayer);
 
 
        if (salto == 1 && puedoSaltar)
          {
            Vector3 movimientoFuerza = Vector3.up;
             rb.AddForce(movimientoFuerza, ForceMode.Impulse);
          }

        puedoSaltar = Physics.Raycast(transform.position, Vector3.down, 1f, layerSuelo);
        



    }
  

    void OnCollisionEnter(Collision collision)
    {
        
        //while (enter == false)
        //{           
            if (collision.gameObject.CompareTag("salto"))
            {
                rb.useGravity = false;
                rb.AddForce(gravedad, ForceMode.Acceleration);
          

                             
            }
          
        //    enter = true;
        //    salir = true;
           
        //}
        //while (salir == true)
        //    {

                if (collision.gameObject.CompareTag("salio"))
                {
                    rb.useGravity = true;
                // rb.AddForce(gravedad2, ForceMode.Acceleration);
                
            }

            //salir = false ;
            //enter = false;
            //}










    }


}
