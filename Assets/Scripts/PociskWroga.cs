using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PociskWroga : MonoBehaviour
{
    public int damage2=10;  //obrażenia (można ustawić je w inspektorze)
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision) 
    {
        Debug.Log(collision.transform.name); //w konsoli pokazuje w co udeża pocisk
        if(collision.transform.tag=="Player") //jeżeli przedmiot posiada tag "enemy" to spełni się warunek i dostanie obrażenia
        {
           
            
            collision.gameObject.GetComponent<PlayerHealth>().TakeDamage(damage2);  //kiedy pocisk będzie miał kolizje z przedmiotem o tagu enemy dostanie obrażenia
        }
    }
}