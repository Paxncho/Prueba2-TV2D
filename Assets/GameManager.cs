using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    GameManager Instance { get; set; }

    int[] Players; //Jugadores
    int jugadaIndex; //(0,5)
    bool correct;

    private Pieza PiezaCorrecta;

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

    private void AddScoreToPlayer(int index, int puntosToAdd)
    {
        if (Players[index] == 0)
        {
            return;
        }
        else
        {
            Players[index] += puntosToAdd;
        }

    }

}
