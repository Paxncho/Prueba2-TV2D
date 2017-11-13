using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    int[] Players; //Jugadores
    int jugadaIndex; //(0,5)

    //RecetaActual Jaime
    
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
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

}
