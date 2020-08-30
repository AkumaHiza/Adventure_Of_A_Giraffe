using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hyena_roar : MonoBehaviour
{
    public GameObject roarToRight;
    public GameObject roarToLeft;
    Vector2 roarPos;
    public float fireRate = 0.5f;
    float nextFire = 0.0f;

    void Update()
    {
        if(GetComponent<Hyena_moving>().inRange && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            roar();
        }
       
    }

    void roar()
    {
        roarPos = transform.position;
        if(GetComponent<Hyena_moving>().movingRight)
        {
            roarPos = roarPos + new Vector2(+0.8f, 0.3f);
            Instantiate (roarToRight, roarPos, Quaternion.identity);
        }
        else
        {
            roarPos = roarPos + new Vector2(-0.1f, 0.3f);
            Instantiate (roarToLeft, roarPos, Quaternion.identity);

        }
    }
}
