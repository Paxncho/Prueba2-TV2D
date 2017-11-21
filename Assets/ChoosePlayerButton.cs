using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChoosePlayerButton : MonoBehaviour {
    public Text textIndex;
    Button MyButton;
    public int indexOfPlayer;

	void Start () {
        MyButton = GetComponent<Button>();
        MyButton.onClick.AddListener(SelecPlayer);
	}
	
    void SelecPlayer()
    {
        GameManager.Instance.Check(indexOfPlayer, GameManager.Instance.currentSelectedPieza);
        //GameManager.Instance.choosedPlayerIndex = indexOfPlayer;
        GameManager.Instance.TimeToChoosePlayer = false;
    }
}
