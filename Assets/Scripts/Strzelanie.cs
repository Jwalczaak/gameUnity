using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Strzelanie : MonoBehaviour
{

    public GameObject pocisk;
    public Transform slotNaPocisk;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

     if(Input.GetKeyDown("space"))
     {
         Debug.Log("Strzal!");
         Instantiate(pocisk, slotNaPocisk.position, slotNaPocisk.rotation);
     }

    }
}
