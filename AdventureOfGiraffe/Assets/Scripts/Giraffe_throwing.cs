using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Giraffe_throwing : MonoBehaviour
{
    public GameObject bulletToRight;
    public GameObject bulletToLeft;
    Vector2 bulletPos;
    public float fireRate = 0.5f;
    float nextFire = 0.0f;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Z) && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            fire();
        }
       
    }

    void fire()
    {
        bulletPos = transform.position;
        if(GetComponent<Giraffe_moving>().facingRight)
        {
            bulletPos = bulletPos + new Vector2(+0.5f, -0.3f);
            Instantiate (bulletToRight, bulletPos, Quaternion.identity);
        }
        else
        {
            bulletPos = bulletPos + new Vector2(-0.5f, -0.3f);
            Instantiate (bulletToLeft, bulletPos, Quaternion.identity);

        }
    }
}
