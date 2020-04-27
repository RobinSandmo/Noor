using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RespawnDetectorScript : MonoBehaviour
{
    public Transform player;
    public Transform checkpoint;
    public Rigidbody rb;

    void OnTriggerEnter(Collider other)
    {
        player.transform.position = checkpoint.transform.position;
        player.transform.rotation = checkpoint.rotation;
        rb.velocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;
    }
}

