using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Playercontrols controls;
    float direction = 0;

    public float speed = 400;

    public Rigidbody2D playerRB;

    private void Awake()
    {
        controls = new Playercontrols();
        controls.Enable();

        controls.Land.Move.performed += ctx =>
        {
            direction = ctx.ReadValue<float>();
        };
    }


    void Update()
    {
        playerRB.velocity = new Vector2(direction * speed * Time.deltaTime, playerRB.velocity.y);
    }
}
