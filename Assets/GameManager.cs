using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    public static GameManager Instance { get; set; }
    public Text PlayersText;

    public bool TimeToChoosePlayer = false;
    public int choosedPlayerIndex;
    public int numPlayers = 1; //Número "Temporal" de jugadores
    int[] Players; //Jugadores
    int jugadaIndex; //(0,5)

    public int cantidadDeJugadas = 5;

    public Pieza PiezaCorrecta;
    public FormaImagen[] formasImagen;

    public List<Pieza> Piezas = new List<Pieza>();
    public Pieza currentSelectedPieza;

    public GameObject gameOverScreen;

    public void Awake()
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

    void OnLevelWasLoaded(int level) {
        GameObject go = GameObject.Find("GameOverPanel");

        if (go != null) {
            gameOverScreen = go;
            go.SetActive(false);
        }
    }

    public void Starting()
    {
        if (gameOverScreen != null)
            gameOverScreen.SetActive(false);

        Play();
        ResetScores();
        jugadaIndex = 0;
        Randomize();
        //ScenesManager.Instance.Panel.SetActive(false);
        //ScenesManager.Instance.Gameover.SetActive(false);
    }

    public void Check(int index, Pieza piezaSeleccionada)
    {
        if (piezaSeleccionada.forma == PiezaCorrecta.forma)
        {
            if (piezaSeleccionada.color == PiezaCorrecta.color)
            {
                AddScoreToPlayer(index, 1);
            }
            else
            {
                AddScoreToPlayer(index, -1);
            }
        }
        else
        {
            AddScoreToPlayer(index, -1);
        }
        jugadaIndex++;

        Debug.Log("Jugada numero = " + jugadaIndex);
        Debug.Log("Jugador " + index + "Tiene " + Players[index] + "Puntos");

        if (jugadaIndex == cantidadDeJugadas) {
            GameOver();
        } else {
            Randomize();
        }
    }

    private void ResetScores()
    {
        for (int i = 0; i < Players.Length; i++)
        {
            Players[i] = 0;
        }
    }

    void AddScoreToPlayer(int index, int toAddScore)
    {
        Players[index] += toAddScore;
    }

    public Sprite getSprite(Pieza.Forma forma)
    {
        for (int i = 0; i < formasImagen.Length; i++)
        {
            if (formasImagen[i].forma == forma)
            {
                return formasImagen[i].imagen;
            }
        }
        return null;
    }

    public void ChangePlayerNum(int num) {
        if (numPlayers + num > 0)
            numPlayers += num;
        PlayersText.text = numPlayers.ToString();
    }

    public void Play() {
        Players = new int[numPlayers];
    }

    public void Randomize()
    {
        foreach (Pieza pieza in Piezas)
        {
            pieza.randomize();
        }
    }

    void GameOver() {
        int winnerPlayer = 0;
        int maxScore = int.MinValue;

        for (int i = 0; i < Players.Length; i++) {
            if (Players[i] > maxScore) {
                winnerPlayer = i;
                maxScore = Players[i];
            }
        }

        gameOverScreen.SetActive(true);

        Text playerWinText = GameObject.Find("NPlayer").GetComponent<Text>();
        playerWinText.text = (winnerPlayer + 1).ToString();

        GameObject.Find("PlayBtn").GetComponent<Button>().onClick.AddListener(Starting);
        GameObject.Find("VolverBtn").GetComponent<Button>().onClick.AddListener(ScenesManager.Instance.toMainMenu);
    }

}
