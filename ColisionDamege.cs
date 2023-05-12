using System.Timers;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColisionDamege : MonoBehaviour
{
    public bool can_damage = true;
    public int colisionDamege = 10;
    public string ColisionTag;

    private void OnCollisionEnter2D(Collision2D coll)
    {
        if ((coll.gameObject.tag == ColisionTag) & (can_damage == true))
        {
            Health health = coll.gameObject.GetComponent<Health>();
            health.TakeHit(colisionDamege);
        }
    }

    public void Ikick(bool damage)
    {
        can_damage = damage;

    }

}

