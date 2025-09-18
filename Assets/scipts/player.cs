using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
/*{
    public int Score { get; private set; }
    public int R = 15; // radius, for reference if needed
    public Sprite SpaceshipSprite;

    private bool isUp;
    private bool isDown;
    private float screenHeight;

    private SpriteRenderer spriteRenderer;

    private void Awake()
    {
        spriteRenderer = gameObject.AddComponent<SpriteRenderer>();
        if (SpaceshipSprite != null)
        {
            spriteRenderer.sprite = SpaceshipSprite;
        }

        // Get screen height in world units
        screenHeight = Camera.main.orthographicSize * 2f;
    }

    private void Start()
    {
        Respawn();
    }

    private void Update()
    {
        // Handle movement
        if (isUp && transform.position.y < screenHeight / 2f)
        {
            Up();
        }
        else if (isDown && transform.position.y > -screenHeight / 2f)
        {
            Down();
        }

        // Check scoring
        if (HasPlayerScoredAPoint())
        {
            Score++;
            Respawn();
        }
    }

    public void Respawn()
    {
        transform.position = new Vector3(transform.position.x, -screenHeight / 2f + 1f, transform.position.z);
        isUp = false;
        isDown = false;
    }

    public void MoveUp(bool move)
    {
        isUp = move;
    }

    public void MoveDown(bool move)
    {
        isDown = move;
    }

    private void Up()
    {
        transform.position += Vector3.up * Time.deltaTime * 5f; // 5 units/sec speed
    }

    private void Down()
    {
        transform.position += Vector3.down * Time.deltaTime * 5f;
    }

    private bool HasPlayerScoredAPoint()
    {
        return transform.position.y >= screenHeight / 2f;
    }
}*/



{
    public Rigidbody2D body;
    public float speed;  
    // Start is called before the first frame update

    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        body.velocity = new Vector2(Input.GetAxis("Horizontal") * speed, Input.GetAxis("Vertical") * speed);

    }
}
