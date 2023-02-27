using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D playerBody;

    private void Start()
    {
        playerBody = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        float dirX = Input.GetAxisRaw("Horizontal");
        playerBody.velocity = new Vector2(dirX * 4f, playerBody.velocity.y);


        if (Input.GetButtonDown("Jump"))
        {
            playerBody.velocity = new Vector3(playerBody.velocity.x, 8f);
        }
    }
}
 