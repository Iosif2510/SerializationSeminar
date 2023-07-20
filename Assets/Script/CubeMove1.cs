using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMove1 : MonoBehaviour
{
    [SerializeField] private CustomAsset rotSpeedContainer;

    private void Update()
    {
        transform.Rotate(Vector3.up, rotSpeedContainer.cubeRotateSpeed * Time.deltaTime);
    }
}
