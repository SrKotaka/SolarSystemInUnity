using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttachCamera : MonoBehaviour
{
    public GameObject target; // the target that the camera should look at
    private Vector3 offset;
    void Start()
    {
        if (target == null) 
        {
            target = gameObject;
            Debug.Log ("AttachCamera target not specified. Defaulting to parent GameObject");
        }
        offset = transform.position - target.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (target)
        {
            transform.position = target.transform.position + offset;
        }
    }
}
