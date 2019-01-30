using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemsToCollect : MonoBehaviour {
    public static int objects = 0;
    private void Awake ()
    {
        objects++;
        Debug.Log(objects);
    }

    void OnTriggerEnter(Collider player)
    {
        if (player.gameObject.CompareTag("Pick Up"))
        {
            player.gameObject.SetActive(false);
        }
    }
} 
