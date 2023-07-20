using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Asset/Enemy", fileName = "New Enemy")]
public class EnemyStat : ScriptableObject
{
    public int hp;
    public int moveSpeed;
    public int damage;
    public string name;

    public float rotateSpeed;
}
