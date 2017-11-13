using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ScenesManager {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void toMinigame(){
		SceneManager.LoadScene ("MiniGame");
	}

	public void toMainMenu()
	{
		SceneManager.LoadScene ("MainMenu");
	}

	public void checkResult(bool isCorrect)
	{
		
	}
}
