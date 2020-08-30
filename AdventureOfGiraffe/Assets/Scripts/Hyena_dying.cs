using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hyena_dying : MonoBehaviour
{
    public GameObject blood;


    void OnCollisionEnter2D(Collision2D bullet)
    {
        if(bullet.gameObject.tag.Equals("Bullet"))
        {
            Instantiate(blood, transform.position,Quaternion.identity);
            Destroy(bullet.gameObject);
            Destroy(gameObject);
        }
    }
    
}
