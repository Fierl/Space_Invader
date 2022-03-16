using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienController : MonoBehaviour
{
    float horizontal;

    public float horizontalSpeed = 3.0f;

    public float timeBetweenJumps = 1f;
    bool canJump = false;
    float jumpTimer;

    // Start is called before the first frame update
    void Start()
    {
         jumpTimer = timeBetweenJumps;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(canJump);
        if (canJump)
        {
            Vector2 position = transform.position;
            position.x = position.x - horizontalSpeed;
            transform.position = position;
            canJump = false;
        }
        else
        {
            jumpTimer -= Time.deltaTime;
            Debug.Log(jumpTimer);
            if (jumpTimer < 0)
                canJump = false;
                jumpTimer = timeBetweenJumps;
        }
    }
}

