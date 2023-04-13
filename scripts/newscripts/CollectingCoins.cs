using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class CollectingCoins : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public int coins;
    public int score=0;
    void Start()
    {
        
    }

    public void OnTriggerEnter(Collider Col)
    {
        if(Col.gameObject.tag=="Coin")
        {
            Debug.Log("Coin Collected");
            coins=coins+1;
            score+= 1;
            SetScore();
            Col.gameObject.SetActive(false);

            
            Destroy(Col.gameObject);

        }

    }
    public void SetScore()
    {
        scoreText.text = "SCORE: " + score.ToString();
    }
    
}
