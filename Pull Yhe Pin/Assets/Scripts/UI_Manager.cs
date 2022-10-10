using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UI_Manager : MonoBehaviour
{
    public GameObject canvas;
    public int levelID;
    public void RetryButton()
    {
        SceneManager.LoadScene(levelID);
    }

    public void StopButton()
    {
        Time.timeScale = 0;
        canvas.transform.GetChild(3).gameObject.SetActive(true);
    }

    public void StartButton()
    {
        Time.timeScale = 1;
        canvas.transform.GetChild(3).gameObject.SetActive(false);

    }
    
    
    
    
}
