﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LoadScene_Stage : MonoBehaviour
{
    // Start is called before the first frame update
    public void SceneLoader(int SceneIndex)
    {
        SceneManager.LoadScene(SceneIndex);
    }

    public void QuitGame()
    {
        print(55555);
        Application.Quit();

    }
}
