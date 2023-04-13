using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine.SceneManagement;
public class GameOverScreen : MonoBehaviour
{
   public TextMeshProUGUI scoreText;
   public int score =0;
   public void Score(int score)
   {
       scoreText.text = "SCORE: " + score.ToString();
   }

   public void RestartButton()
   {
     SceneManager.LoadScene(0);
   }

  
    
}
