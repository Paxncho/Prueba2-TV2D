using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
[Serializable]
public class Pieza : MonoBehaviour
{
    public enum Forma
    {
        Triangulo, Cuadrado, Circulo, Estrella
    }
    
    public Forma forma;

     public Color color = Color.white;
    // Use this for initialization
    void Start()
    {
        color.a = 1;
    }

    // Update is called once per frame
    void Update()
    {
        Image sp = GetComponent<Image>();
        sp.color = color;
        sp.sprite = GameManager.Instance.getSprite(forma);
    }

    void OnMouseDown()
    {

        //SceneManager.Instance.showResultado((GameManager.Instance.pieza.forma.forma = forma && GameManager.Instance.pieza.color = color));

    }
}

