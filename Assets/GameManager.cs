using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    public GameObject template;
    public static GameManager Instance { get; set; }

    public Text PlayersText;

    int numPlayers; //Número "Temporal" de jugadores
    int[] Players; //Jugadores
    int jugadaIndex; //(0,5)

    private Pieza PiezaCorrecta;
    public FormaImagen[] formasImagen;

    public void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
     
        DontDestroyOnLoad(this);
    }


    public void Starting()
    {
        ResetScores();

        for (int i = 0; i < 9; i++)
        {
            GameObject pieza =  Instantiate(template) as GameObject;
            pieza.SetActive(true);
            pieza.transform.SetParent(template.transform.parent);

            pieza.GetComponent<Pieza>().color = Color.red;
            pieza.GetComponent<Pieza>().forma = Pieza.Forma.Circulo;


        }
        
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


    }

    void GenerarReceta()
    {


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
        //Cargar Minigame
    }

}
