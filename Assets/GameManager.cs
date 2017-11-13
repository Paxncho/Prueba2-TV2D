using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public static GameManager Instance { get; set; }

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
}
