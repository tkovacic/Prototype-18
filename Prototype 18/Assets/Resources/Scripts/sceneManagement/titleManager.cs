using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class titleManager : MonoBehaviour {

    //SCENE MANAGEMENT [START]

    public void closeApp()
    {
        Application.Quit();
    }

    public void loadLoginScene()
    {
        SceneManager.LoadScene(1);
    }

    public void loadSettingsScene()
    {
        SceneManager.LoadScene(2);
    }

    //SCENE MANAGEMENT [END]
}
