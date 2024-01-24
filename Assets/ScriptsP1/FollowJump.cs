using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowJump : MonoBehaviour
{
    public GameObject Player;

    // Update is called once per frame
    void Update()
    {
        transform.position = Player.transform.position + new Vector3(-2.2600002f, 5.21000004f, 0.2399998f);
    }
}
