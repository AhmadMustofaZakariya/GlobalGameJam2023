using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniGameManager : MonoBehaviour
{
    public int maxItem;
    public GameObject portal;
    public int collectedItem { get; private set; }

    private void Awake()
    {
        portal.SetActive(false);
    }
    private void Update()
    {
        if (collectedItem == maxItem)
        {
            portal.SetActive(true);
        }
    }

    public void countItem()
    {
        collectedItem++;
    }
}
