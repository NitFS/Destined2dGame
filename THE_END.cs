using System.Timers;
using System;
using UnityEngine;
using System.Collections;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class THE_END : MonoBehaviour
{
    GameObject  player;
    float       direction = -1f;


    void Start()
    {
        player = GameObject.FindWithTag("Player");
    }

    

    void Update()
    {
        float directionny = player.transform.position.y - transform.position.y;
        float directionnx = player.transform.position.x - transform.position.x;
        if ((Mathf.Abs(directionny) <= 5) & (Mathf.Abs(directionnx) <= 3))
        {
            SceneManager.LoadScene(3);
        }
    }


}
