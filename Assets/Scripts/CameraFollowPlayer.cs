using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowPlayer : MonoBehaviour
{
    public GameObject player;
    public Vector3 cameraOffset;

    void Start()
    {
        cameraOffset = new Vector3(0, 5, -7);
    }

    void LateUpdate()
    {
        transform.position = player.transform.position + cameraOffset;
    }
}
