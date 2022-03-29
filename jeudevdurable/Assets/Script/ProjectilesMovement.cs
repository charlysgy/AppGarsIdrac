using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectilesMovement : MonoBehaviour
{
    private Rigidbody rb;
    private float screenWidth = Screen.width;
    private float screenHeight = Screen.height;
    private float moveSpeed = 150;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        // get position of the bin
        Vector3 binPos = Camera.main.WorldToScreenPoint(transform.position);

        //get input
        int i = 0;
        while (i < Input.touchCount)
        {
            // move right
            if (Input.GetTouch(i).position.x > screenWidth / 2)
            {
                MoveCharacter(1.0f, 1.0f);
            }
            // move left
            else if (Input.GetTouch(i).position.x < screenWidth / 2)
            {
                MoveCharacter(-1.0f, 1.0f);
            }
            i++;
        }

        // check if bin is outside of screenWidth
        if (binPos.x < 50)
        {
            transform.position = new Vector3(-2, transform.position.y, 0);
            rb.velocity = Vector3.zero;
        }

        if (binPos.x > screenWidth - 50)
        {
            transform.position = new Vector3(2, transform.position.y, 0);
            rb.velocity = Vector3.zero;
        }

        if (binPos.y > screenHeight - 100)
        {
            Destroy(this);
        }
    }

    private void MoveCharacter(float input_x, float input_y)
    {
        rb.AddForce(new Vector2(input_x * moveSpeed * Time.deltaTime, input_y * moveSpeed * Time.deltaTime));
    }
}
