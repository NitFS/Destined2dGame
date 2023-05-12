using System.Timers;
using System;
using UnityEngine;
using System.Collections;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Death:MonoBehaviour
{
    GameObject player;

  void Start()
    {
        player = GameObject.FindWithTag("Player");
    }

  void Update()
  {
    if(player == null) 
    { 
      
      SceneManager.LoadScene(1);

    }
  }

}