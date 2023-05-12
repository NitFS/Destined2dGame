using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSkript : MonoBehaviour{

    private Transform player;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void LateUpdate()
    {
        Vector3 temp = transform.position;
        temp.x = player.position.x;
        temp.y = player.position.y+2;

        transform.position = temp;
    }

}