using UnityEngine;

public class OperadoresLogicos : MonoBehaviour
{
    public bool temChave = true;
    public float distancia = 1.5f;
    public bool inimigoProximo = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (temChave && distancia < 2)
        {
            Debug.Log("A porta foi aberta!");
        }
        else
        {
            Debug.Log("Você não pode abrir a porta");
        }

        int vida = 10;
        if (inimigoProximo || vida <=0) 
        {
            Debug.Log("Cuidado! Fuja ou se prepare para lutar!");
        }

        bool alavancaAtivada = false;
        if (!alavancaAtivada) 
        {
            Debug.Log("A alavanca ainda não foi ativada");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
