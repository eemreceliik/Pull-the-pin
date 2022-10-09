using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public List<GameObject> balls = new List<GameObject>();
    public TextMeshProUGUI scoreText;
    private float _score;
    private float tempScore = 0;

    private void Start()
    {
        var ballCount = (float)balls.Count;
        _score = (100 / ballCount) ;
        Debug.Log(balls.Count);
        Debug.Log(_score);


    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("ColoredBall"))
        {
           
           tempScore += _score;
           scoreText.text = "%" + tempScore.ToString(CultureInfo.InvariantCulture); 
           Debug.Log("++");
           other.gameObject.tag = "Untagged";
        }
        

        if (other.CompareTag("UnColoredBall"))
        {
            Destroy(other.gameObject);
        }
    }
    
    
    
}
