using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy: MonoBehaviour
{
    public GameObject Enemy;
    public Transform[] position;
    public bool seleccion;
 
    void Start()
    {
        foreach (Transform posi in position)
        {
         Instantiate(Enemy, posi);
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

