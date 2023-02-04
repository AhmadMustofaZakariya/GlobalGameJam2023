using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniGameItem : MonoBehaviour
{
    public MiniGameManager miniGameManager;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        MiniGameManager miniGameManager = collision.GetComponent<MiniGameManager>();
        if(miniGameManager != null)
        {
            miniGameManager.countItem();
            gameObject.SetActive(false);
        }
    }
}
