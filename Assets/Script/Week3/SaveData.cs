using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveData
{
    public DateTime saveTime;
    public string characterName;
    public int currentHP;
    public float xPos;
    public float yPos;

    public SaveData(DateTime dateTime, string name, int hp, float x, float y)
    {
        saveTime = dateTime;
        characterName = name;
        currentHP = hp;
        xPos = x;
        yPos = y;
    }
}
