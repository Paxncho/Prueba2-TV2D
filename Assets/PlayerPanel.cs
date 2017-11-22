using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerPanel : MonoBehaviour {

    Image MyImage;
    int timesToDo = 1;
    bool TimeToDestroy;
    public GameObject PlayerButton;
    private void Start()
    {
        MyImage = GetComponent<Image>();
    }

    void Update () {
        if (GameManager.Instance.TimeToChoosePlayer == true)
        {
            if (timesToDo == 1)
            {
                createJugadores();
            }
            timesToDo = 0;
            TimeToDestroy = true;
            MyImage.enabled = true;
        }
        else
        {
            if (TimeToDestroy == true)
            {
                DestroyPlayersButtons();
                TimeToDestroy = false;
            }
            timesToDo = 1;
            MyImage.enabled = false;

        }
	}

    public void createJugadores()
    {
        int cantJugadores = GameManager.Instance.numPlayers;
        for (int i = 1; i <= cantJugadores; i++)
        {
            GameObject buttonP = Instantiate(PlayerButton, transform) as GameObject;
            buttonP.GetComponentInChildren<Text>().text = "Jugador " + i;
            buttonP.GetComponent<ChoosePlayerButton>().indexOfPlayer = i - 1;
        }
    }

    public void DestroyPlayersButtons()
    {
        int cantChildren = gameObject.transform.childCount;
        Debug.Log(cantChildren);
        for (int i = 1; i <= cantChildren; i++)
        {
            Destroy(transform.GetChild(i - 1).gameObject);
        }
    }
}
