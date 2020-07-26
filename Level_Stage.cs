using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Level_Stage : MonoBehaviour
{
    public Button[] lvlButtons;
    void Start()
    {
        int levelAt = PlayerPrefs.GetInt("levelAt", 3);

        for (int i = 0; i < lvlButtons.Length; i++)
        {
            if (i + 3 > levelAt)
                lvlButtons[i].interactable = false;
        }
    }  
}      
           
   


