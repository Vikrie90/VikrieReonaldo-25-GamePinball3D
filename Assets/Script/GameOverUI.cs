using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverUI : MonoBehaviour
{
    public Button mainMenuButton;
    public Button creditSceneButton;

    private void Start()
    {
        // setup event saat button di klik
        mainMenuButton.onClick.AddListener(MainMenu);
        creditSceneButton.onClick.AddListener(CreditScene);
    }

    public void MainMenu()
    {
        // kembali ke main menu
        SceneManager.LoadScene(0);
    }

    public void CreditScene()
    {
        SceneManager.LoadScene(2);
    }
}
