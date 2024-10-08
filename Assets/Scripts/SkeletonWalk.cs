using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkeletonWalk : MonoBehaviour
{
    private Vector3 _start;
    [SerializeField] private Transform end;
    [SerializeField] private float Xspeed;
    [SerializeField] private float Zspeed;
    private float yy;
    private void Start()
    {
        _start = transform.position;
        yy = transform.position.y;
    }

    void Update()
    {
        transform.position = new Vector3(transform.position.x+Xspeed*Time.deltaTime, yy, transform.position.z+Zspeed*Time.deltaTime);
    }
}
