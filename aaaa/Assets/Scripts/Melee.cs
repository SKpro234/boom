using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Melee : MonoBehaviour
{
    public int damage = 1;

    public PlayerMovement rightFacing;
    public LayerMask Enemies;
    public Vector2 attackRange;
    private Collider2D[] enemiesToDamage;
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
         if (Input.GetButtonDown("Fire1")){
            if(rightFacing.GetComponent<PlayerMovement>().isFacingRight){
            enemiesToDamage = Physics2D.OverlapBoxAll(new Vector2(transform.position.x + 1,transform.position.y),
            attackRange, 0, Enemies);
            }
            else
            {
            enemiesToDamage = Physics2D.OverlapBoxAll(new Vector2(transform.position.x - 1,transform.position.y),
            attackRange, 0, Enemies);
            }
            for(int i = 0; i < enemiesToDamage.Length; i++){
                enemiesToDamage[i].GetComponent<EnemyBehavior>().TakeDamage(damage);
            }

         }
    }
    
    void OnDrawGizmosSelected(){
        Gizmos.color = Color.red;
        Gizmos.DrawWireCube(new Vector3(transform.position.x + 1, transform.position.y, transform.position.z), attackRange);
        Gizmos.DrawWireCube(new Vector3(transform.position.x - 1, transform.position.y, transform.position.z), attackRange);
    }

}