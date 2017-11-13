using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    int[] Players; //Jugadores
    int jugadaIndex; //(0,5)
    bool correct;

    //RecetaActual Jaime

    public void Check(int index)
    {

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
