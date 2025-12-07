using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour {

    public void RestartButton() {
        SceneManager.LoadScene("1.TheCornBegins");
    }

    public void ExitButton() {
        SceneManager.LoadScene("0.StartScreen");
    }
    
}