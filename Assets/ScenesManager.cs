using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class ScenesManager: MonoBehaviour {

	//public GameObject botonjugador;
    //public GameObject Panel;
    //public GameObject Gameover;

    public static ScenesManager Instance;
    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(this);

        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Start()
	{
        
    }

    void OnLevelWasLoaded(int level)
    {
        GameObject go = GameObject.Find("PanelJugadores");

        if (go != null)
        {
            //Panel = go;
            //Panel.SetActive(false);
        }
    }

	void Update()
	{
        
    }

	public void toMinigame()
    {
		SceneManager.LoadScene ("MiniGame");
        GameManager.Instance.Starting(); //Deja todos los puntajes de los jugadores en 0;
        
    }

	public void toMainMenu()
	{
		SceneManager.LoadScene ("MainMenu");
	}

	public void showResultado(bool isCorrect)
	{
		if (isCorrect) {
			foreach(GameObject objeto in GameObject.FindGameObjectsWithTag("Finish"))
			{
				objeto.SetActive(true);
			}
		}
	}
}
