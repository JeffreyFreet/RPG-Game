using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightController : MonoBehaviour {

    public Transform target;
    public Vector3 offset;

    private void LateUpdate()
    {
        transform.position = target.transform.position + offset;
    }
}
