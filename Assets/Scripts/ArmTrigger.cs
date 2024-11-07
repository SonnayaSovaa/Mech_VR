using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmTrigger : MonoBehaviour
{
    [SerializeField] private GameObject arm1;
    [SerializeField] private GameObject arm2;
    [SerializeField] private AudioSource auSource;
    [SerializeField] private AudioClip zvuk;

    private void OnTriggerEnter(Collider other)
    {
        auSource.PlayOneShot(zvuk);
        arm1.SetActive(true);
        arm2.SetActive(true);

        
    }
}
