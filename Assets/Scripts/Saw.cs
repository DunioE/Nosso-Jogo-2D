using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Saw : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    [SerializeField] private float distance = 5f;
    private Vector3 startPosition;
    private float direction = 1f;

    private void Start()
    {
        startPosition = transform.position;
    }

    private void Update()
    {
        transform.Translate(Vector3.right * speed * direction * Time.deltaTime);
        if (Vector3.Distance(transform.position, startPosition) >= distance)
        {
            direction *= -1f;
        }
    }
}
