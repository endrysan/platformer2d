using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : Unit
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        Bullet bullet = other.GetComponent<Bullet>();
        if (bullet) {
            ReceiveDamage();
        }
    }
}
