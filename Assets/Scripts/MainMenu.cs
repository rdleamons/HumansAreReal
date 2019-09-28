using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update

    public Button newGameButton;

    public Button creditsButton;

    public Button htpButton;

    public Button quitButton;

    public string newGameSceneName;

    public void NewGame()
    {
        Debug.Log("Start Game");
        SceneManager.LoadScene(newGameSceneName);
    }

    public void Credits()
    {
        SceneManager.LoadScene("Credits");
    }

    public void HowtoPlay()
    {
        SceneManager.LoadScene("HowToPlay");
    }

    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}
