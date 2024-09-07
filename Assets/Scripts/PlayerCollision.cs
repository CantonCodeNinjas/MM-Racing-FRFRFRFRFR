using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.transform.tag == "Finish")
        {
            Debug.Log("Game Over");
            Time.timeScale = 0;
        }
    }
}
