using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float velX = 5f;
    float velY = 0f;
    Rigidbody2D body;
    
    void Start()
    {
        body = GetComponent<Rigidbody2D> ();
    }

    void Update()
    {
        body.velocity = new Vector2 (velX, velY);
        Destroy(gameObject, 0.5f);
    }
}
