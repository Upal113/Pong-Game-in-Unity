using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    // References to Objects for Control
    public bool isPlayer1;
    public float speed;
    public Rigidbody2D rb;
    public Vector3 startPosition;
    private float movement;

    void Start()
    {
        startPosition = transform.position;
    }

    // Attatch Paddle movements by preset project Object movement
    void Update()
    {
        if (isPlayer1)
        {
            movement = Input.GetAxisRaw("vertical2");
        }
        else
        {
            movement = Input.GetAxisRaw("Vertical");
        }
        rb.velocity = new Vector2(rb.velocity.x, movement* speed);
    }

    // Reset Game Objects
    public void Reset()
    {
        rb.velocity = Vector2.zero;
        transform.position = startPosition;
    }
}
