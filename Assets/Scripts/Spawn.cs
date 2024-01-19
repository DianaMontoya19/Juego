using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject moneda;
    public Transform[] posicion;
    public bool seleccion;
    private GameObject referencia;
    void Start()
    {
        foreach (Transform posi in posicion)
        {
           referencia = Instantiate(moneda, posi);
        }
    }

    private void Update()
    {
        if(seleccion)
        {
            Destroy(referencia);
        }
    }

}

