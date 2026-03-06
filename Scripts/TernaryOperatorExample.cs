using UnityEngine;

public class TernaryOperatorExample : MonoBehaviour
{
    public int energia = 30;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        string status = (energia > 50) ? "Energia alta!" : "Energia baixa";
        Debug.Log(status);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
