using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject moneda;
    public Transform[] posicion;
    public bool seleccion;
 
    void Start()
    {
        foreach (Transform posi in posicion)
        {
         Instantiate(moneda, posi);
        }
    }

    //private void Update()
    //{
    //    if(seleccion)
    //    {
    //        Destruir(referencia);
    //    }
    //}


}

