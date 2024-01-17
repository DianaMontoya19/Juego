using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour
{
    private float velocidadz = 2f;
   
    bool limite = true;


    // Update is called once per frame
    void Update()
    {
    
            transform.Translate(0f, 0f, velocidadz * Time.deltaTime);
            if (gameObject.name == "Enemigo")
            { 
            
                  if ((transform.position.z > 12.5f) || (transform.position.z < 9f))
                   {
                       velocidadz = -velocidadz ;

                    }
            }
            if (gameObject.name == "Enemigo2")
            {
               
                if ((transform.position.z > 11f) || (transform.position.z < 8f))
                {
                    velocidadz = -velocidadz ;

                }
            }

       
        
    }
}
