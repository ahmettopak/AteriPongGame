using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
   
    public void OnCollisionEnter2D(Collision2D collision)
    {
       
        if (collision.gameObject.tag == "PlayerLeft") {
            SceneManager.LoadScene("GameOverScene");
           
        }
        if (collision.gameObject.tag == "PlayerRight") {
            SceneManager.LoadScene("GameOverScene");
            
        }

    }
   
}
