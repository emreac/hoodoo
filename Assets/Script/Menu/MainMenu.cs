﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
 
    public void StartButton()
    {
        SceneManager.LoadScene("GameScene");
    }
 
    public void OptionsButton()
    {
        SceneManager.LoadScene("OptionMenu");
    }
    public void LevelsButton()
    {
        SceneManager.LoadScene("LevelSelection");
    }
        public void MainButton()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void Exit()
    {

        Application.Quit();
    }


}
