

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using  UnityEngine.SceneManagement;


public class Gamebackground : MonoBehaviour
{  bool alive = true;
    private void OnCollisionEnter (Collision collision)
    {
        if (collision.gameObject.tag == "Player") 
        {
            // Kill the player
            Die();
        }
    }
   public void Die ()
    {
        alive = false;
        
         Invoke("Restart", 0);
    }

    void Restart ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
   
}
