using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPl1 : MonoBehaviour
{
    public GameObject Player;

    // Update is called once per frame
    void Update()
    {
        transform.position = Player.transform.position + new Vector3(-1f, 0.2f, 0f);
    }
}
