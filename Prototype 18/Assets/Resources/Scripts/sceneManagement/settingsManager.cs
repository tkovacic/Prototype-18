using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class settingsManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    //SCENE MANAGEMENT [START]

    public void loadTitleScene()
    {
        SceneManager.LoadScene(0);
    }

    //SCENE MANAGEMENT [END]
}
