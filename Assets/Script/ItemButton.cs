using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemButton : MonoBehaviour
{
    public ItemAsset itemAsset;

    private void Awake()
    {
        GetComponent<Image>().sprite = itemAsset.itemSprite;
        GetComponent<Button>().onClick.AddListener(ItemClicked);
    }

    public void ItemClicked()
    {
        Debug.Log($"This {itemAsset.itemName} is {itemAsset.cost}$");
    }
}
