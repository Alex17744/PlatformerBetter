using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGun : MonoBehaviour
{
    public float Speed = 0.5f;
    public float rightMax = 3.103f;
    public float leftMax = 0.589f;
    Vector2 currentDirection = Vector2.right;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x >= rightMax)
        {
            currentDirection = Vector2.left;
            GetComponent<SpriteRenderer>().flipX = false;
        }
        else if (transform.position.x <= leftMax)
        {
            currentDirection = Vector2.right;
            GetComponent<SpriteRenderer>().flipX = true;
        }
        transform.Translate(currentDirection * Speed * Time.deltaTime);
    }
}
