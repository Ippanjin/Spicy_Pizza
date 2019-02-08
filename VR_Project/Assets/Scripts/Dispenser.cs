﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dispenser : MonoBehaviour
{
    public GameObject[] inventoryItems;      // List of items that are in the dispenser
    public Transform dispensePosition;  // Position where the items were come out
    /// <summary>
    /// Use this method to dispense the item.
    /// </summary>
    /// <param name="itemNumber">ID of the item in the </param>
    public void Dispense(int itemNumber)
    {
        Debug.Log("fuck this " + inventoryItems[itemNumber].name);
        // Dispense an object here using the Instantiate<> function

        GameObject instGameObject;
        instGameObject = Instantiate<GameObject>(inventoryItems[itemNumber]);
        instGameObject.transform.position = dispensePosition.position;
        instGameObject.transform.localScale = dispensePosition.localScale;

     

    }
}
