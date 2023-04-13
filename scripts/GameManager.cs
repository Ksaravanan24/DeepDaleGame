using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using TMPro;

public class GameManager : MonoBehaviour {

    int score;
  
    
   

    [SerializeField] TextMeshProUGUI scoreText;

    

    public void IncrementScore ()
    {
        score++;
        scoreText.text = "SCORE: " + score.ToString();
        // Increase the player's speed
       
    }

   
    private void Start () {

	}

	private void Update () {
	       
	}
}