using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public int life = 100;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Damage(20);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Damage(int _value) 
    {
        life -= _value;
        Debug.Log("Jogador tomou dano! Vida restante: " + life);
    }
}
