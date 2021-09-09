using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform playerTransform;

    void Start()
    {

    }

    void Update()
    {
        var x = playerTransform.position.x + 20;
        var y = playerTransform.position.y;
        transform.position = new Vector3(x, y, transform.position.z);
    }
}