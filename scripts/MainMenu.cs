using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void ExitButton()
    {
    
        Debug.Log("GAMECLOSED");
    }

    public void StartButton()
    {
        SceneManager.LoadScene(1);
    }
    
}
