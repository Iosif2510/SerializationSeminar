using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    public EnemyStat stat;

    private void Start()
    {
        Debug.Log($"I am {stat.name}");
    }

    private void Update()
    {
        transform.Rotate(Vector3.forward, stat.rotateSpeed * Time.deltaTime);
    }
}
