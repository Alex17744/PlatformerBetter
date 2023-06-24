using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{
    public float Speed = 0.5f;
    public float rightMax = -8.206f;
    public float leftMax = -12.093f;
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
            GetComponent<SpriteRenderer>().flipX = true;
        }
        else if (transform.position.x <= leftMax)
        {
            currentDirection = Vector2.right;
            GetComponent<SpriteRenderer>().flipX = false;
        }
        transform.Translate(currentDirection * Speed * Time.deltaTime);
    }
}


