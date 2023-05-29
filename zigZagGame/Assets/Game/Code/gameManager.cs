using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManager : MonoBehaviour
{
    public static bool isPaused;
    
    public void PauseGame()
    {
        if(Time.timeScale == 1)
        {
            Time.timeScale = 0;
            UIManager.instance.ShowHidePausedTxt(true);
        }
        else
        {
            Time.timeScale = 1;
            UIManager.instance.ShowHidePausedTxt(false);
        }
    }
}
