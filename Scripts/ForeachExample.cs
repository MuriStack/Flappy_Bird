using UnityEngine;

public class ForeachExample : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        string[] inimigos = { "Orc", "Goblin", "Troll", "Dragon", "Skeleton" };

        foreach (string inimigo in inimigos) // for coisa in qualquer_coisa -> python
        {
            Debug.Log("Inimigos encontrados: " + inimigo);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
