using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    Vector3 ProjectileDirection;
    public float velocity=0;
    // Start is called before the first frame update
    void Start()
    {
        

        ProjectileDirection = GameObject.FindAnyObjectByType<Movimientohorizontal>().transform.position - transform.position; ;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position+ProjectileDirection.normalized*velocity*Time.deltaTime;
        
    }
}
