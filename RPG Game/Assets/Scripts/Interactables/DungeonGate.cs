using UnityEngine;

public class DungeonGate : Interactable {

    public override void Interact()
    {
        //Obviously need to grab key and check inventory for said key
        Debug.Log("Opening Gate!");
        gameObject.SetActive(false);
    }
}
