using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Hyena_moving : MonoBehaviour
{
   
   public float moveSpeed = 3f;
   Transform leftWayPoint;
   Transform rightWayPoint;
   Vector3 localScale;
   public bool movingRight = true;
   Rigidbody2D body;

   public GameObject player;
   public bool inRange = false;

   public float attackDistance = 3f;
   private float dist = 0f;
   private float dist2 = 0f;
   private float high = 1f;
   private float high_dist = 0f;
   private bool exist = true;

    void Start()
    {
        localScale = transform.localScale;
        body = GetComponent<Rigidbody2D> ();
        leftWayPoint = GameObject.Find("LeftWayPoint").GetComponent<Transform> ();
        rightWayPoint = GameObject.Find("RightWayPoint").GetComponent<Transform> ();
    }

    void Update()
    {
        if(player == null) exist = false;
        else
        {
        high_dist = Math.Abs(player.transform.position.y - transform.position.y);
        dist = player.transform.position.x - transform.position.x;
        dist2 = transform.position.x - player.transform.position.x;
        }

        if(movingRight == true && (dist < attackDistance) && (dist > 0) && (high_dist < high) && exist) inRange = true;
        else if(movingRight == false && (dist2 < attackDistance) && (dist2 > 0) && (high_dist < high) && exist) inRange = true;
        else inRange = false;


        if(transform.position.x > rightWayPoint.position.x)
        {
            movingRight = false;
        }
        if(transform.position.x < leftWayPoint.position.x)
        {
            movingRight = true;
        }

        if(movingRight && inRange == false)
        {
            moveRight ();
        }
        else if(inRange == false)
        {
            moveLeft ();
        }
    }
    void moveRight()
    {
        movingRight = true;
        localScale.x = 0.5f;
        transform.localScale = localScale;
        body.velocity = new Vector2 (localScale.x * moveSpeed, body.velocity.y);
    }
    void moveLeft()
    {
        movingRight = false;
        localScale.x = -0.5f;
        transform.localScale = localScale;
        body.velocity = new Vector2 (localScale.x * moveSpeed, body.velocity.y);
    }
}
