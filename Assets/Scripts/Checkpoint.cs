using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.transform.tag == "Player")
        {
            PlayerManager.lastCheckPointPos = transform.position;
            GetComponent<SpriteRenderer>().color = Color.green;
        }
    }
}
