using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Melee : MonoBehaviour
{
    public int damage = 1;

    public PlayerMovement Player;
    public LayerMask Enemies;
    public Vector2 attackRange;
    private Collider2D[] enemiesToDamage;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
         if (Input.GetButtonDown("Fire1")){
            if(Input.GetButton("Vertical") && !(Player.GetComponent<PlayerMovement>().isGrounded)){
            enemiesToDamage = Physics2D.OverlapBoxAll(new Vector2(transform.position.x,transform.position.y - 1),
            attackRange, 0, Enemies);         
            }
            else if(Player.GetComponent<PlayerMovement>().isFacingRight){
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
