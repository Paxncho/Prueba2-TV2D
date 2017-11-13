using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pieza : MonoBehaviour
{
    public enum Forma
    {
        Triangulo, Cuadrado, Circulo, Estrella
    }
    [SerializeField]
    public FormaImagen forma;
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
        sp.sprite = forma.imagen;
    }

    void OnMouseDown()
    {

        //SceneManager.Instance.showResultado((GameManager.Instance.pieza.forma.forma = forma && GameManager.Instance.pieza.color = color));

    }
}

