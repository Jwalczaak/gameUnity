using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtakWroga : MonoBehaviour
{
    private float Timer;
	public float Cooldown = 2f;
	public Rigidbody Pocisk;
	public float Wyrzut = 20f;
	public	Transform Lufa;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Timer += Time.deltaTime;
	if(Timer>=Cooldown){
		Rigidbody NowyPocisk = Instantiate(Pocisk,transform.position, transform.rotation);
		NowyPocisk.velocity=transform.forward*Wyrzut;
		Timer = 0.0f;
	}
    }
}
