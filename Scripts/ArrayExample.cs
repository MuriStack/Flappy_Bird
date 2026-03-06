using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    string[] armas = {"Espada", "Arco", "Lança" };

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Primeira arma: " + armas[0]);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
