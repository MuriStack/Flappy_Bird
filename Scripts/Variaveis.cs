using UnityEngine;

public class Variaveis : MonoBehaviour
{

    private int         lifes = 3;
    private string      namePlayer = "Maria";
    private float       gravity = 9.80665f;
    private bool        isPlayer = true;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Number of Lifes: " + lifes);
        Debug.Log("The name is: " + namePlayer);
        Debug.Log("Gravity is: " + gravity);
        Debug.Log("Is Player: " + isPlayer);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
