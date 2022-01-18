using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cel : MonoBehaviour
{
public int health = 50;  //życie (można ustawić je w inspektorze)
public int currentHealth;


public HealthBar HealthBar;
     void Start()
    {
        currentHealth = health;
        HealthBar.SetMaxHealth(health);
    }

    public void TakeDamage (int amount)   //otrzymywanie obrażeń
    {
        //health-=amount;
        currentHealth-=amount;
        HealthBar.SetHealth(currentHealth);
        if(currentHealth<=0)
        {
           Die();      //wykona się funkcja Die kiedy życie spanie poniżej 0 lub będzie równe 0
        }
    }

    // Update is called once per frame
    void Die()
    {
        Destroy(gameObject); //zostaje zniszczone kiedy życie spadnie do 0 lub poniżej
    }
}
