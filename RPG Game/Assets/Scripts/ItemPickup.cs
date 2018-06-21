﻿using UnityEngine;

public class ItemPickup : Interactable {

    public override void Interact()
    {
        //base.Interact();

        PickUp();
    }

    void PickUp()
    {
        Debug.Log("Picking up item.");
        // Add to Inventory
        Destroy(gameObject);
    }
}