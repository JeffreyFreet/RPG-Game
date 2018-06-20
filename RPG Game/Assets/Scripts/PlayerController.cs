using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerController : MonoBehaviour {

    private NavMeshAgent navAgent;
    public Interactable focus;
    public Transform target;

	// Use this for initialization
	void Start () {
        navAgent = GetComponent<NavMeshAgent>();
	}
	
	// Update is called once per frame
	void Update () {

        if(target != null)
        {
            navAgent.SetDestination(target.position);
        }

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Input.GetMouseButtonDown(0))
        {
            if (Physics.Raycast(ray, out hit, 100))
            {

                //Handling Interactable objects
                Interactable interactable = hit.collider.GetComponent<Interactable>();
                if(interactable != null)
                {
                    SetFocus(interactable);;
                }

                //Handling Standard movement
                if (hit.transform.gameObject.layer == LayerMask.NameToLayer("Ground"))
                {
                    navAgent.destination = hit.point;
                    RemoveFocus();
                }
            }
        }
	}

    //These 2 functions are responsible for focusing on an object that can be interacted with
    void SetFocus(Interactable newFocus)
    {
        focus = newFocus;
        FollowTarget(focus);
    }
    void RemoveFocus()
    {
        focus = null;
        RemoveTarget();
    }

    //These functions will track the interactable object and move towards them, a regular move will cancel this out
    public void FollowTarget(Interactable newTarget)
    {
        navAgent.stoppingDistance = newTarget.radius * .8f;
        target = newTarget.transform;;
    }
    public void RemoveTarget()
    {
        navAgent.stoppingDistance = 0f;
        target = null;
    }
}
