using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameObstacle : MonoBehaviour
{
    
    public int damage;


    private void Update()
    {
        //LifeController controlVida = FindAnyObjectByType<LifeController>();
        //controlVida.vida -= damage * Time.deltaTime;
       
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        LifeController controlVida = FindAnyObjectByType<LifeController>();
        controlVida.vida -= damage;
    }
    
}
