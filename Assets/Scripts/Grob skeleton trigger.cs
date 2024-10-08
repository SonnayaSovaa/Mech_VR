using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Grobskeletontrigger : MonoBehaviour
{
    [SerializeField] private Transform spawnPoint;
    [SerializeField] private GameObject skeleton;
    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.GameObject());
        Instantiate(skeleton, spawnPoint.position, skeleton.transform.rotation);
    }
}
