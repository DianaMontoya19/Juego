using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Proyectiles : MonoBehaviour
     
{
   
    Cañon lanzamiento;
    public float initialSpeed = 5f;
    public string disparo;
    Rigidbody rb;
    bool yaDisparo = false;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        lanzamiento = FindObjectOfType<Cañon>();
      
        Debug.Log(lanzamiento.grados);
    }

    // Update is called once per frame
    private void Update()
    {
        float shoot = Input.GetAxisRaw(disparo);
        if (shoot ==1 && !yaDisparo)
       {

            launchProjectile();
       }
    }

    void launchProjectile()
    {
        // calcular las componentes vertical y horizontal
        float launchAngleRad = lanzamiento.grados * Mathf.Deg2Rad;
        float initialVelocityX = initialSpeed * Mathf.Cos(launchAngleRad);
        float initialVelocityY = initialSpeed * Mathf.Sin(launchAngleRad);
        Vector3 initialVelocity = new Vector3(initialVelocityX, initialVelocityY, 0f);

        //Asignar velocidad inicial al proyectil



        rb.velocity = initialVelocity;

        yaDisparo = true;

    }
}
