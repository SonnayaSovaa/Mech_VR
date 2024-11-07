using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioControl : MonoBehaviour
{
    [SerializeField] AudioClip otherClip;
    [SerializeField] AudioSource audioSource;

    private void OnTriggerEnter(Collider other)
    {
        audioSource.clip = otherClip;
        audioSource.Play();
    }
}
