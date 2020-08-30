using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Giraffe_health : MonoBehaviour
{
    public int maxHealth = 3;
    public int currentHealth;

    public HealthBar healthBar;
    public GameObject blood;
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    void OnCollisionEnter2D(Collision2D roar)
    {
        if(roar.gameObject.tag.Equals("Roar"))
        {
           Destroy(roar.gameObject);
           TakeDamage(1);
           if(currentHealth == 0)
           {
               Instantiate(blood, transform.position,Quaternion.identity);
               Destroy(gameObject);
           }
        }
    }

    void TakeDamage(int damage)
    {
        currentHealth = currentHealth - damage;

        healthBar.SetHealth(currentHealth);
    }
}
