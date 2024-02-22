using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class creditui : MonoBehaviour
{
    public Button backButton;

    private void Start()
    {
        backButton.onClick.AddListener(BackMenu);
    }

    private void BackMenu()
    {
        SceneManager.LoadScene("main menu");
    }
}
