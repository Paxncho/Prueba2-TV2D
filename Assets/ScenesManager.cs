using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ScenesManager: MonoBehaviour {

	void Start()
	{
	}

	void Update()
	{
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
