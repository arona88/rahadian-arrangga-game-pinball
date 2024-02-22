using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class mainmenuui : MonoBehaviour
{
    public Button playButton;
    public Button exitButton;
    public Button creditButton;

    private void Start()
    {
        playButton.onClick.AddListener(PlayGame);
        exitButton.onClick.AddListener(ExitGame);
        creditButton.onClick.AddListener(CreditScene);
    }

    public void PlayGame()
    {
        SceneManager.LoadScene("Pinball_Game");
    }

    private void ExitGame()
    {
        Application.Quit();
    }

    private void CreditScene()
    {
        SceneManager.LoadScene("credit_");
    }
}
