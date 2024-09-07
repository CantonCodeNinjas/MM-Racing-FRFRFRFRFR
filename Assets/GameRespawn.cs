using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameRespawn : MonoBehaviour
{
    public float threshold;


    void FixedUpdate()
    {
        if(transform.position.y < threshold)
        {
            transform.position = new Vector3(0.41f, 2.32f,
                0.005f) ;
        }
    }
}