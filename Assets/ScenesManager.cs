using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ScenesManager: MonoBehaviour {

    public static ScenesManager Instance;
    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        DontDestroyOnLoad(this);
    }

    void Start()
	{

	}

	void Update()
	{

	}

	public void toMinigame()
    {
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
