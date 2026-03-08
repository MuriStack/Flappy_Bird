using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    Rigidbody2D rbPlayer;
    [SerializeField] float jumpForce;

    SpriteRenderer spriteR;

    [SerializeField] Sprite[] playerSprites;

    [SerializeField] int index = 0;

    [SerializeField] private float maxGravity = 1.9f;

    private float currentGravity;

    [SerializeField] private float timelerp;

    GameManager gameManager;

    [SerializeField] int score = 1;


    void Start()
    {
        rbPlayer = GetComponent<Rigidbody2D>();

        spriteR = GetComponent<SpriteRenderer>();

        currentGravity = rbPlayer.gravityScale;

        gameManager = FindFirstObjectByType<GameManager>();

        InvokeRepeating(nameof(AnimateSprite), 0.1f, 0.1f);

    }

    void Update()
    {

        if (gameManager.isDeath) return;

        if (Keyboard.current.spaceKey.wasPressedThisFrame || Mouse.current.leftButton.wasPressedThisFrame)
        {
            rbPlayer.linearVelocity = Vector2.zero;

            rbPlayer.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);

            rbPlayer.gravityScale = currentGravity;

            transform.rotation = Quaternion.Euler(0, 0, 25f);
        }

        if (!Keyboard.current.anyKey.wasPressedThisFrame)
        {
            rbPlayer.gravityScale += 0.01f;
        }

        if (rbPlayer.gravityScale >= maxGravity)
        {
            rbPlayer.gravityScale = maxGravity;

            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0, 0, -90), timelerp * Time.deltaTime);
        }
    }

    void AnimateSprite()
    {
        index++;

        if (index >= playerSprites.Length)
        {
            index = 0;
        }

        spriteR.sprite = playerSprites[index];
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Scoring"))
        {
            gameManager.SetScore(score);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Obstacle"))
        {
            gameManager.ShowGameOver();
            enabled = false; // desativa o script Player
        }
    }
}