using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CreditSceneUI : MonoBehaviour
{
    public Button mainMenuButton;

    private void Start()
    {
        // setup event saat button di klik
        mainMenuButton.onClick.AddListener(MainMenu);
    }

    public void MainMenu()
    {
        // kembali ke main menu
        SceneManager.LoadScene(0);
    }
}
