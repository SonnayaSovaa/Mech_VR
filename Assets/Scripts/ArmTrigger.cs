using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmTrigger : MonoBehaviour
{
    [SerializeField] private GameObject arm1;
    [SerializeField] private GameObject arm2;


    private void OnTriggerEnter(Collider other)
    {
        arm1.SetActive(true);
        arm2.SetActive(true);
    }
}
