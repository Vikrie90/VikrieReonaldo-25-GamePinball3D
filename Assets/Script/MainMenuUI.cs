using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuUI : MonoBehaviour
{
    public Button playButton;
    public Button ExitButton;


    private void Start()
    {
        playButton.onClick.AddListener(PlayGame);
        ExitButton.onClick.AddListener(ExitGame);   
    }
    public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
