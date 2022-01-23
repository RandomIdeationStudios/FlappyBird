using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    public float velocity = 1.4f;
    public Rigidbody2D rb;
    public GameManager refer;

    public void Jump()
    {
        rb.velocity = Vector2.up * velocity;
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        refer.GameOver();
    }
}