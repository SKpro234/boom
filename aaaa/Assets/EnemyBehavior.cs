using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    public float HP;
    public float MaxHP = 3;
    // Start is called before the first frame update
    void Start()
    {
        HP = MaxHP;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void TakeDamage(float damage){
        HP -= damage;
        Debug.Log("boom");
        if(HP <= 0){
            Destroy(gameObject);
        } 

    }
}
