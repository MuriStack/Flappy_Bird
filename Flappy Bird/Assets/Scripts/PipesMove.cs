using UnityEngine;
using UnityEngine.InputSystem;

public class PipesMove : MonoBehaviour
{
    [SerializeField] float speed = 1f;
    [SerializeField] float destroyPosition = -9.9f;

    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);

        if (transform.position.x <= destroyPosition) 
        {
            Destroy(gameObject);
        }
    }
}
