using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class ScenesManager: MonoBehaviour {

	public GameObject botonjugador;

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

	public void createJugadores()
	{
		int cantJugadores = GameManager.Instance.numPlayers;
		GameObject Panel = GameObject.Find ("PanelJugadores");
		for (int i = 1; i <= cantJugadores; i++) {
			Text texto = Instantiate(botonjugador, Panel.transform).GetComponentInChildren<Text>();
			texto.text = "Jugador " + i;
		}
	}
}
