using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

    public void LoadLevel(string name)
    {
        //Brick.breakableCount = 0;

        Debug.Log("level load requested for:" + name);
        Application.LoadLevel(name);
        //SceneManager.LoadScene(name);
    }

    public void LoadNextLevel()
    {
        //Brick.breakableCount = 0;

        Application.LoadLevel(Application.loadedLevel + 1);
    }


    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit Game");
    }

    /*public void BrickDestroyed()
    {
        if(Brick.breakableCount <= 0)
        {
            LoadNextLevel();
        }
    }*/
}
