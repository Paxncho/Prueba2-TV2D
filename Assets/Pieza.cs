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
    [SerializeField]
    public Forma forma;
    [SerializeField]
 
    public Color color;
    // Use this for initialization
    void Start()
    {

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

