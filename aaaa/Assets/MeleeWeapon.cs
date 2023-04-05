using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class MeleeWeapon : MonoBehaviour
{
    public int damage = 1;
    void Start()
    {
        
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        var enemy = collision.collider.GetComponent<EnemyBehavior>();
       if(enemy){
        enemy.TakeDamage(damage);
       }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
