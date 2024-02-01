using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject objectToFollow;

    void LateUpdate()
    {
        this.transform.position = objectToFollow.transform.position + new Vector3(0, 0, -10);       
    }
}
