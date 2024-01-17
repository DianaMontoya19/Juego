using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;

public class singravedad : MonoBehaviour
{
    private Rigidbody rb;
    public Vector3 gravedad = new Vector3 (0f, -9.8f, 0f); 
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(gravedad, ForceMode.Acceleration);
    }
}
