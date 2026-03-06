using UnityEngine;
using System.Collections.Generic;

public class ListExample : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        List <int> numeros = new List <int> ();
        
        numeros.Add(10);
        numeros.Add(20);
        numeros.Add(30);
        numeros.Add(40);
        numeros.Add(50);

        Debug.Log("Primeiro numero: " + numeros[0]); // 10
        Debug.Log("Total de elementos: " + numeros.Count); // 5
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
