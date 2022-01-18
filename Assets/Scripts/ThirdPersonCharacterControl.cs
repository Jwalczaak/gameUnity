using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonCharacterControl : MonoBehaviour
{
    public float Speed;

	void Update ()
    {
        PlayerMovement();
    
    }

    void PlayerMovement()
    {
        float hor = Input.GetAxis("Horizontal");  //zmienna pobiera dane z klawiatury do poruszania się w lewo/prawo (a lub d/ stzrałki w lewo i prawo)
        float ver = Input.GetAxis("Vertical");  //zmienna pobiera dane z klawiatury poruszania się do przodu i do tyłu (w lub s / strzałki w góre lub w dół)
        Vector3 playerMovement = new Vector3(ver, 0f, -hor) * Speed * Time.deltaTime; //zmienna w której tworzy się nowy Vector3 (pierwsza zmienna ver, odpowiada osi x, druga zmienna osi Y(wysokość), trzecia zmienna hor osi Z)
        transform.Translate(playerMovement, Space.Self);
    }
  
}