using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Asset/Item")]
public class ItemAsset : ScriptableObject
{
    public Sprite itemSprite;
    public string itemName;
    public int cost;
}
