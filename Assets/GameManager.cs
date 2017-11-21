﻿using System.Collections;
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

    public Pieza PiezaCorrecta;
    public FormaImagen[] formasImagen;

    public List<Pieza> Piezas = new List<Pieza>();
    public Pieza currentSelectedPieza;

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

    public void Starting()
    {
        Play();
        ResetScores();
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

        Randomize();


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


}
