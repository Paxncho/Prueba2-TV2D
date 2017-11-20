﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class Pieza : MonoBehaviour
{
    Button MyButton;

    public enum Forma
    {
        Triangulo, Cuadrado, Circulo, Estrella
    }
    
    public Forma forma;
    public Color color = Color.white;
    Image sp;

    void Start()
    {
        sp = GetComponent<Image>();
        color.a = 1;
        randomize();

        MyButton = GetComponent<Button>();
        MyButton.onClick.AddListener(check);
    }

    void Update()
    {
<<<<<<< HEAD
        //sp.color = color;
        //sp.sprite = GameManager.Instance.getSprite(forma);
=======


>>>>>>> 28634c49b41e40febe62a679998846443384d6c0
    }

    void check()
    {
        Debug.Log("2");
        ScenesManager.Instance.createJugadores();
        Debug.Log("3");
    }

    void randomize()
    {
        int randomForma = Random.Range(0, 3);
        int randomColor = Random.Range(0, 4);
        int randomCorrecto = Random.Range(0, 2);


        switch (randomForma)
        {
            case 0: forma = Forma.Triangulo; break;
            case 1: forma = Forma.Cuadrado; break;
            case 2: forma = Forma.Circulo; break;
            case 3: forma = Forma.Estrella; break;
        }

        switch (randomColor)
        {
            case 0: color = Color.red; break;
            case 1: color = Color.yellow; break;
            case 2: color = Color.magenta; break;
            case 3: color = Color.green; break;
        }

        sp.sprite = GameManager.Instance.getSprite(forma);
        sp.color = color;


        if (randomCorrecto == 1)
        {
            GameManager.Instance.PiezaCorrecta = this;
<<<<<<< HEAD
            Image piezaCorrecta = GameObject.FindGameObjectWithTag("Recipe").GetComponent<Image>();
            piezaCorrecta.color = color;
            piezaCorrecta.sprite = GameManager.Instance.getSprite(forma);
=======

            Debug.Log("Escogi");


            Image piezaCorrecta = GameObject.FindGameObjectWithTag("Recipe").GetComponent<Image>();
            piezaCorrecta.color = color;
            piezaCorrecta.sprite = GameManager.Instance.getSprite(forma);
            Debug.Log("ESCOJIDO");

>>>>>>> 28634c49b41e40febe62a679998846443384d6c0
        }
    }
}

