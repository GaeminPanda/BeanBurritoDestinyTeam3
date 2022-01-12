using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    [SerializeField] private Transform testplayer;

    [SerializeField] private Transform respawnPoint;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("TestPlayer"))
        testplayer.transform.position = respawnPoint.transform.position;
        Physics.SyncTransforms();
    }

   
}
