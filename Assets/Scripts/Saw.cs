using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Saw : MonoBehaviour
{
    public float speed = 2;
    int dir = 1;

    public Transform rightcheck;
    public Transform leftCheck;


    void FixedUpdate()
    {
        transform.Translate(Vector2.right * speed * dir * Time.fixedDeltaTime);
        if (Physics2D.Raycast(rightcheck.position, Vector2.down, 2) == false)
            dir = -1;

        transform.Translate(Vector2.right * speed * dir * Time.fixedDeltaTime);
        if (Physics2D.Raycast(leftCheck.position, Vector2.down, 2) == false)
            dir = 1;
    }
}
