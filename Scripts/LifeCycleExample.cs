using UnityEngine;

public class LifeCycleExample : MonoBehaviour
{
    void Awake() 
    {
        Debug.Log("Awake chamado! O objeto foi criado");
    }

    void OnEnable()
    {
        Debug.Log("Onenable chamado! O objeto foi ativado");
    }

    void Start() 
    {
        Debug.Log("Start chamado! O jogo foi criado");
    }


}
