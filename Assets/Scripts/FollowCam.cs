using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCam : MonoBehaviour
{

    public Transform player;
    public float followSpeed = 1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 destination = new Vector3(player.position.x, player.position.y, -10);
        transform.position = Vector3.Slerp(transform.position, destination, followSpeed * Time.deltaTime);
    }
}
