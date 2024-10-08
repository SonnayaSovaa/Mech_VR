using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class Floating : MonoBehaviour
{
    private float min_y;
    [SerializeField] private float delta;
    [SerializeField] private float phase;

    private float xx, zz;
    private void Start()
    {
        min_y = transform.position.y;
        xx = transform.position.x;
        zz = transform.position.z;
    }

    void Update()
    {
        transform.position = new Vector3(xx, min_y + phase*Mathf.Sin(Time.fixedTime) * delta - delta, zz);
    }

    
}
