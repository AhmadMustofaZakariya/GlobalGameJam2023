using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lubang : MonoBehaviour
{
    public CharacterController2DBrackey CharacterController2DBrackey;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            CharacterController2DBrackey.ResetPosition();
            Debug.Log("Reset Position");
        }
    }
}
