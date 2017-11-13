using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

    }
    void OnMouseDown()
    {

        //SceneManager.Instance.showResultado((GameManager.Instance.pieza.forma = forma && GameManager.Instance.pieza.color = color));

    }
}
