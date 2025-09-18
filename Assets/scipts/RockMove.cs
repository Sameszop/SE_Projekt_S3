using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockMove : MonoBehaviour
{
    [SerializeField] private float speed = 2f;

    private GameObject bigRock;

    private GameObject smallRock;

    void Update()
    {
        // Move rock straight down
        transform.Translate(Vector2.down * speed * Time.deltaTime);

        // Destroy when off screen (optional)
        if (transform.position.y < -10f)
        {
            Destroy(gameObject);
        }
    }
}
