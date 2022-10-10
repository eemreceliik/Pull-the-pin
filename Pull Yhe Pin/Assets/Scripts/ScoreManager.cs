using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public List<GameObject> balls = new List<GameObject>();
    public TextMeshProUGUI scoreText;
    private float _score;
    private float tempScore = 0;
    private int _checkBall;
    public int levelID;
    public GameObject particles;
    private void Start()
    {
        var ballCount = (float)balls.Count;
        _score = (100 / ballCount) ;
        
    }

    private void Update()
    {
        if (balls.Count==_checkBall)
        {
            RunParticles();
            Invoke(nameof(NextLevel),1.5f);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("ColoredBall"))
        {
            _checkBall++;
           tempScore += _score;
           scoreText.text = "%" + tempScore.ToString(CultureInfo.InvariantCulture); 
           other.gameObject.tag = "Untagged";
        }
        
        if (other.CompareTag("UnColoredBall"))
        {
            particles.transform.GetChild(2).gameObject.SetActive(true);
            particles.transform.GetChild(2).gameObject.GetComponent<ParticleSystem>().Play();
            Destroy(other.gameObject);
        }
    }

    private void RunParticles()
    {
        particles.transform.GetChild(0).gameObject.SetActive(true);
        particles.transform.GetChild(1).gameObject.SetActive(true);
    }
    private void NextLevel()
    {
        SceneManager.LoadScene(levelID);

    }
    
    
    
}
