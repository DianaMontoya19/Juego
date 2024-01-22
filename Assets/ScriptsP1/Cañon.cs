using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cañon : MonoBehaviour
{

    public float grados = 0f;
    public string angulo;
    public string anguloNeg;

    // Update is called once per frame
    void Update()
     {
        float angle = Input.GetAxisRaw(angulo);
        float angleNeg = Input.GetAxisRaw(anguloNeg);

        if (angle==1 )
         {
            
                float gradRad = grados  * Mathf.Deg2Rad;
                float gradX = Mathf.Cos(gradRad);
                


                transform.Rotate(new Vector3(-gradX,0f , 0f));



                Debug.Log("grados" + grados);
                grados++ ;


            }
        if (angleNeg == 1)
        {

            float gradRad = grados * Mathf.Deg2Rad;
            float gradX = Mathf.Cos(gradRad);



            transform.Rotate(new Vector3(gradX, 0f, 0f));



            Debug.Log("grados" + grados);
            grados++;


        }




    }

}

