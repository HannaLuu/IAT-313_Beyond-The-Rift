using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TP_Clone : MonoBehaviour
{
    public float speed = 20f;
    public int teleportDistance = 5;
    public bool colliding = false;

    public Vector3 startPosition;
    public Vector3 currentPosition;

    bool isFlipped = false;

    SpriteRenderer sprite;
    public TimeManager timeManager;
    public Rigidbody2D rb;
    public Teleport teleportScript;

    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.right * speed;
        startPosition = transform.position;

        sprite = GetComponent<SpriteRenderer>();
    }
    private void OnTriggerEnter2D(Collider2D hitInfo)
    {
        colliding = true;
        sprite.color = new Color(0.5f, 0, 0, 0.5f);
    }

    private void OnTriggerExit2D(Collider2D hitInfo)
    {
        colliding = false;
        sprite.color = new Color(1, 1, 1, 0.5f);
    }

    // Update is called once per frame
    void Update()
    {
        currentPosition = transform.position;

        if (Input.GetButtonUp("Fire2"))
        {
            teleportScript.teleportMode = false;
            Destroy(gameObject);
            timeManager.UndoSlowMotion();
        }

        if (Input.GetButtonDown("Fire3"))
        {
            teleportScript.teleportMode = false;
            Destroy(gameObject);
            timeManager.UndoSlowMotion();
        }

        if (currentPosition.x >= (startPosition.x + teleportDistance) && isFlipped == false)
        {
            transform.Rotate(0f, 180f, 0f);
            rb.velocity = -rb.velocity;
            isFlipped = true;
        }
        if (currentPosition.x <= (startPosition.x - teleportDistance) && isFlipped == false)
        {
            transform.Rotate(0f, 180f, 0f);
            rb.velocity = -rb.velocity;
            isFlipped = true;
        }
        if (isFlipped && currentPosition.x == startPosition.x)
        {
            transform.Rotate(0f, 180f, 0f);
            rb.velocity = -rb.velocity;
            isFlipped = false;
        }
    }
}
