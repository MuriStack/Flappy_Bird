using UnityEngine;

public class UpdateSample : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Update em execução: " + Time.deltaTime);
    }

    private void FixedUpdate()
    {
        Debug.Log("FixedUpdate em execução: " + Time.deltaTime);
    }

    private void LateUpdate()
    {
        Debug.Log("LateUpdate em execução!");
    }

}
