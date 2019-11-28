using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject followedObject;
    public Vector3 offset;
    void Start()
    {
        
    }

 
    void Update()
    {
        transform.position = followedObject.transform.position + offset;
        transform.LookAt(followedObject.transform);
    }
}
