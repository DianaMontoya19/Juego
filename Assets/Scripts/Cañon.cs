using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cañon : MonoBehaviour
{

    public float grados = 0f;

 

    // Update is called once per frame
    void Update()
     {


        if (Input.GetKeyDown(KeyCode.G))
         {
            
                float gradRad = grados  * Mathf.Deg2Rad;
                float gradX = Mathf.Cos(gradRad);
                


                transform.Rotate(new Vector3(-gradX,0f , 0f));



                Debug.Log("grados" + grados);
                grados++ ;


            }
        if (Input.GetKeyDown(KeyCode.F))
        {

            float gradRad = grados * Mathf.Deg2Rad;
            float gradX = Mathf.Cos(gradRad);



            transform.Rotate(new Vector3(gradX, 0f, 0f));



            Debug.Log("grados" + grados);
            grados++;


        }




    }

}

