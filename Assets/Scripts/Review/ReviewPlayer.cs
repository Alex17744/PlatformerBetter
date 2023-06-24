using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using JetBrains.Annotations;
using UnityEngine;

public class ReviewPlayer : MonoBehaviour

{
    public float leftMax = -6.73f;
    public float upMax = 3.93f;
    public float speed = 5f;
    public float left, right, top, bottom;
    private float x, y;

    // Start is called before the first frame update
    void Start()
    {

    }

    void Update()
    {
        x += Input.GetAxisRaw("Horizontal") * speed * Time.deltaTime;
        y += Input.GetAxisRaw("Vertical") * speed * Time.deltaTime;

        x = Mathf.Clamp(x, left, right);
        y = Mathf.Clamp(y, bottom, top);

        transform.position = new Vector2(x, y);
    }
}