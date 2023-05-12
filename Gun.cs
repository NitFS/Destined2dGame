using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Timers;
using System;

public class Gun : MonoBehaviour
{
    GameObject player;
    public Bullet bullet;
    public Transform shotPoint;
 
    private float timeBtwShots;
    public float starttimeBtwShots;


    void Start()
    {
       
        player = GameObject.FindWithTag("Player");
        
    }

    void Update()
    {
        if (timeBtwShots <= 0)
        {
        float direction = player.transform.position.x - transform.position.x;
		float directionY = player.transform.position.y - transform.position.y;

        if (((Mathf.Abs(direction) <25) & (Mathf.Abs(direction) > 1)) & ((Mathf.Abs(directionY) <4)))
            {
                Shopt();
            }
            
        }
        else
        {
            timeBtwShots -= Time.deltaTime;
        }

    }

    public void Shopt()
    {
        var newBullet = Instantiate(bullet, shotPoint.position, shotPoint.rotation);
        newBullet.isCharFacingRight = GetComponentInParent<Character>().m_facingRight;
        timeBtwShots = starttimeBtwShots;
       
    }
   
}
