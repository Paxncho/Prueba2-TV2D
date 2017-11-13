using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    GameManager Instance { get; set; }

    int[] Players; //Jugadores
    int jugadaIndex; //(0,5)

<<<<<<< HEAD
    //RecetaActual Jaime
    
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
=======
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
>>>>>>> origin/master

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

}
