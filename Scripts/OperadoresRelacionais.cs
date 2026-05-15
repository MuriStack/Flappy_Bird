///seila///
///aqui é melhor do que ali///

using UnityEngine;

public class OperadoresRelacionais : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int vida = 25;
        int nivel = 12;

        if (vida < 30)
        {
            Debug.Log("ALERTA! Sua vida esta muito baixa");
        }

        if (nivel > 10)
        {
            Debug.Log("Voce e um jogador experiente!");
        }
        else
        {
            Debug.Log("Continue treinando para alcancar niveis mais altos");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
