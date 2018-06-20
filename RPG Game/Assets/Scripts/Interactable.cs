using UnityEngine;

public class Interactable : MonoBehaviour {

    public float radius = 3f;   //How close you need to be to interact

    //Visualize the interaction area
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, radius);
    }
}
