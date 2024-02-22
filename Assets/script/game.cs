using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class game : MonoBehaviour
{
    public Button mainmenuButton;

    private void Start()
    {
        mainmenuButton.onClick.AddListener(MainMenu);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("main_menu");
    }
}
