using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StoryMenu : MonoBehaviour
{
    // Start is called before the first frame update

    public Button continueButton;

    public string Clubhouse;

    public void GotoGame()
    {
        SceneManager.LoadScene("Clubhouse");
    }
}
