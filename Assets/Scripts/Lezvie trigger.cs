using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Lezvietrigger : MonoBehaviour
{
    private bool a = false;
    private Vector3 start;
    private bool was = false;
    
    [SerializeField] private AudioSource auSource;
    [SerializeField] private AudioClip zvuk;
    private void OnTriggerEnter(Collider other)
    {
        start = this.gameObject.transform.position;
        a = true;
        Debug.Log(11111111111);
    }

    private void Update()
    {
        if (a)
        {
            transform.position= Vector3.Lerp(transform.position, new Vector3(start.x, start.y-6f, start.z),0.1f);
            if (!was)
            {
                auSource.PlayOneShot(zvuk);
                was = true;
            }
        }
        
    }
}
