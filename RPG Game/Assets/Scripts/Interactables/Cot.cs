using UnityEngine;

public class Cot : Interactable {

    public override void Interact()
    {
        Debug.Log("This is a " + transform.name);
        base.Interact();
        // Make some sort of popup
        // This may or may not get scrapped
        // if bed actually needs interaction
    }
}
