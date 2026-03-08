using UnityEngine;

public class MoveObjects : MonoBehaviour
{

    [SerializeField] float speed;
    MeshRenderer renderM;


    void Start()
    {
        renderM = GetComponent<MeshRenderer>();
    }


    void Update()
    {
        renderM.material.mainTextureOffset += new Vector2(speed * Time.deltaTime, 0);
    }
}