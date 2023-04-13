using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class EndGame : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.name == "enemy")
        {

            SceneManager.LoadScene("EndGameScene");

        }
    }
}