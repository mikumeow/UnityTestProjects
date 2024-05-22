using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameRunning = true;
    public float restartDelay = 2f;

    public GameObject completeLevelUI;
    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);
    }
    internal void EndGame()
    {
        Debug.Log("GameOver");
        if (gameRunning)
        {
            Invoke("Restart", 2f);
            gameRunning = false;
        }
    }

    private void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    internal bool GameRunning()
    {
        return gameRunning;
    }
}
