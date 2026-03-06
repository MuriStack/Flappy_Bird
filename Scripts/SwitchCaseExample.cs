using UnityEngine;

public class SwitchCaseExample : MonoBehaviour
{
    public string dificuldade = "facil";

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        switch (dificuldade)
        {
            case "facil":
                Debug.Log("Modo facil ativado");
                break;

            case "medio":
                Debug.Log("Modo medio ativado");
                break;

            case "dificil":
                Debug.Log("Modo dificil ativado");
                break;

            default:
                Debug.Log("Modo invalido! Selecione: Facil, Medio ou dificil");
                break;  
                
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
