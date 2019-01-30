using UnityEngine;
using System;
using UnityEngine.AI;

public class AgroDetection : MonoBehaviour {

    public event Action<Transform> OnAgro = delegate { };
   
    private void OnTriggerEnter(Collider other)
    {
        var player = other.GetComponent<PlayerMovement>();
        if(player != null)
        {
            Debug.Log("agro");
            OnAgro(player.transform);
        }
    }
}
