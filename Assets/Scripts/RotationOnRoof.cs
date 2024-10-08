using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationOnRoof : MonoBehaviour
{
    [SerializeField] private float dir_speed;
    void Update()
    {
        transform.Rotate(0,  dir_speed * Time.deltaTime, 0);
    }
}
