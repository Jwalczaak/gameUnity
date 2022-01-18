using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    float bulletSpeed=1100; //szybkość pocisku
    public GameObject bullet;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Fire()
    {
        GameObject tempBullet = Instantiate(bullet, transform.position, transform.rotation) as GameObject; 
        Rigidbody tempRigidBodyBullet = tempBullet.GetComponent<Rigidbody>();
        tempRigidBodyBullet.AddForce(tempRigidBodyBullet.transform.forward*-1*bulletSpeed); //wyszczelenie pocisku
        Destroy(tempBullet, 0.5f);  //wystrzelony pocisk znika po upływie czasu
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))    //po kliknięciu lewego przycisku myszy zostanie wykonana funkcja Fire
        {
            Fire(); //Po spełnieniu warunku wykona się funkcja Fire, odpowiadająca za wystrzał pocisku
        }
    }
}
