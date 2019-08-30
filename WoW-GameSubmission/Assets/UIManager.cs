using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    GameObject[] gameStartObjects;
    GameObject[] gameRuntimeObjects;
    GameObject[] gameEndtimeObjects;

    public Text endGameText;

    // Use this for initialization
    void Start()
    {
        Time.timeScale = 0;
        gameStartObjects = GameObject.FindGameObjectsWithTag("GameStart");
        gameRuntimeObjects = GameObject.FindGameObjectsWithTag("GameRunTime");
        gameEndtimeObjects  = GameObject.FindGameObjectsWithTag("GameEndTime");

        this.hideGameRuntimeObjects();
        this.hideGameEndtimeObjects();
    }

    public void BeginGame()
    {
        Time.timeScale = 1;
        this.hideStartObjects();
        this.showGameRuntimeObjects();
    }

    public void EndGame(string winner)
    {
        this.endGameText.text = "The winner is: " + winner + "!!!!!!";

        this.hideGameRuntimeObjects();
        this.showGameEndtimeObjects();

        Time.timeScale = 0;
    }

    //Reloads the Level
    public void Reload()
    {
        var activeScene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(activeScene.name);
        this.showGameRuntimeObjects();
    }

    public void showStartObjects()
    {
        foreach (GameObject g in this.gameStartObjects)
        {
            g.SetActive(true);
        }
    }
    public void hideStartObjects()
    {
        foreach (GameObject g in this.gameStartObjects)
        {
            g.SetActive(false);
        }
    }


    public void showGameRuntimeObjects()
    {
        foreach (GameObject g in this.gameRuntimeObjects)
        {
            g.SetActive(true);
        }
    }
    public void hideGameRuntimeObjects()
    {
        foreach (GameObject g in this.gameRuntimeObjects)
        {
            g.SetActive(false);
        }
    }


    public void showGameEndtimeObjects()
    {
        foreach (GameObject g in this.gameEndtimeObjects)
        {
            g.SetActive(true);
        }
    }
    public void hideGameEndtimeObjects()
    {
        foreach (GameObject g in this.gameEndtimeObjects)
        {
            g.SetActive(false);
        }
    }
}
