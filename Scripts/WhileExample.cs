using UnityEngine;

public class WhileExample : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int progresso = 0;

        while (progresso <= 100) 
        {
            Debug.Log("Carregando..." + progresso + "%");
            progresso++;
        }

        Debug.Log("Carregamento completo");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
