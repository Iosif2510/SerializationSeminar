using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMove1 : MonoBehaviour
{
    [SerializeField] private float rotateSpeed = 100;

    private void Update()
    {
        transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
    }
}
