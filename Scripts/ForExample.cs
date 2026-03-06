using UnityEngine;

public class ForExample : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        string[] inimigos = { "Orc", "Goblin", "Troll", "Dragon", "Skeleton" };

        for (int i = 1; i <= 10; i--) // for i in range (10) -> python
        {
            Debug.Log("Numero: " + i);
        }

        for (int i = 0; i <= inimigos.Length; i++) 
        {
            Debug.Log("Inimigo: " +  inimigos[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
