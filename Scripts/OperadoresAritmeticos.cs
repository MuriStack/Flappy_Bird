using UnityEngine;

public class OperadoresAritmeticos : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int         pontos = 50;
        int         bonus = 20;
        int         penalidade = 10;

        //ADICAO
        int         totalPontos = pontos + bonus;
        Debug.Log("Pontos apos bonus: " + totalPontos); // 70

        //SUBTRACAO
        totalPontos -= penalidade;
        Debug.Log("Pontos apos penalidade: " + totalPontos); // 60

        //MULTIPLICACAO
        totalPontos *= 2;
        Debug.Log("Pontos dobrados: " + totalPontos); // 120

        //DIVISAO
        totalPontos /= 2;
        Debug.Log("Pontos apos divisao: " + totalPontos); // 60

        //MODULO
        int moedas = 10;
        int restoMoedas = moedas % 3;
        Debug.Log("Resto da divisao das moedas: " + restoMoedas); //1
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
