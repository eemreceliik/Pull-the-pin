using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

public class BallManager : MonoBehaviour
{


    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag($"UnColoredBall"))
        {
            ColorSelection(other);
            other.gameObject.tag = "ColoredBall";
            other.gameObject.AddComponent<BallManager>();
        }
    }

    private static void ColorSelection(Component other)
    {
        var random = new Random();
        var tempValue = random.Next(1, 4);

        if (tempValue == 1) 
        {
            other.gameObject.GetComponent<Renderer>().material.color = Color.red;
        }

        if (tempValue == 2) 
        {
            other.gameObject.GetComponent<Renderer>().material.color = Color.blue;
        }
        if (tempValue == 3) 
        {
            other.gameObject.GetComponent<Renderer>().material.color = Color.yellow;
        }
        if (tempValue == 4) 
        {
            other.gameObject.GetComponent<Renderer>().material.color = Color.green;
        }

    }


        
        
    
}
    
    

    