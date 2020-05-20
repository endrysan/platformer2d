using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveableMonster : Monster
{
    [SerializeField]
    private float speed = 2.0F;

    private Bullet bullet;

    private void Awake() {
        bullet = Resources.Load<Bullet>("Bullet");
    }

    private void OnTriggerEnter2D(Collider2D other) {
        Unit unit = other.GetComponent<Unit>();

        if (unit && unit is Character) {
            if (Mathf.Abs(unit.transform.position.x - transform.position.x) < 0.3F) ReceiveDamage();
            else unit.ReceiveDamage();
        }
    }
}
