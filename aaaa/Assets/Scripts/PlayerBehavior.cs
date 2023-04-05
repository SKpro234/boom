using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{
    public int HP;
    public int MaxHP = 3;
    public float invulnTimeSet = 1;
    public float invulnTime;
    public LayerMask Enemies;
    private Collider2D enemyCollide;
    // Start is called before the first frame update
    void Start()
    {
        HP = MaxHP;
    }
    // Update is called once per frame
    void Update()
    {
        invulnTime -= Time.deltaTime;
            enemyCollide = Physics2D.OverlapBox(transform.position, transform.position, 0, Enemies);
            if(invulnTime <= 0 && enemyCollide){
                TakeDamage(enemyCollide.GetComponent<EnemyBehavior>().collisionDamage);
                invulnTime = invulnTimeSet;
                Debug.Log("owie");
            }
    }
    
    
    public void TakeDamage(int damage){
        HP -= damage;
        if(HP <= 0){
            Destroy(gameObject);
        } 

    }
}
