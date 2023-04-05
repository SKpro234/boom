using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    public int HP;
    public int MaxHP = 3;
    public int collisionDamage = 1;
    // Start is called before the first frame update
    void Start()
    {
        HP = MaxHP;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void TakeDamage(int damage){
        HP -= damage;
        Debug.Log("boom");
        if(HP <= 0){
            Destroy(gameObject);
        } 

    }
}
