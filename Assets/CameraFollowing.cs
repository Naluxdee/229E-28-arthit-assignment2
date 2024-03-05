using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowing : MonoBehaviour
{
    public Camera mainCamera;
    public GameObject targetObject;

    void Start()
    {
        mainCamera.transform.SetParent(targetObject.transform);
    }
}
