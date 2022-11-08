using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuControl : MonoBehaviour {
    
    Button Quit;
    public void PlayGame() {
      //  SceneManager.LoadScene("GameScene");
        Quit = GetComponent<Button>();
        Quit.gameObject.SetActive(false);
    }
    public void QuitGame() {
        //Application.Quit();
        Debug.LogWarning("Game exit");
        Quit = GetComponent<Button>();
        Quit.gameObject.SetActive(false);

    }
}
