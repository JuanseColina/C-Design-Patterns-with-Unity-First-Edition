using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour
{
    public static Manager Instance;
    public int score = 0;
    public int startingLevel = 1;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            Debug.Log("New instance initialized...");

        }
        else if (Instance != this)
        {
            Destroy(this.gameObject);
            Debug.Log("Existing instance found, deleting self...");
        }
        {
            
        }
    }

    public void StartGame()
    {
        Debug.Log("New game has started...");
        SceneManager.LoadScene(startingLevel);
    }
}