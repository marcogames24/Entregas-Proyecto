using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gamecoin : MonoBehaviour
{
    public int value;
    private void OnTriggerEnter2d(Collider2D other)
    {

        GamePoints pointsControl = FindAnyObjectByType<GamePoints>();
        pointsControl.points += value;
        pointsControl.textPoints.text = "Points: "+ pointsControl.points;
        Destroy(gameObject);
    }






}
