using UnityEngine;

public class ifElseExample : MonoBehaviour
{
    public int pontos = 75;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (pontos >= 90)
        {
            Debug.Log("Você é um jogador nível PRO");
        }
        else if (pontos >= 50)
        {
            Debug.Log("Você é um jogador nível intermediário");
        }
        else 
        {
            Debug.Log("Você precisa treinar mais");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
