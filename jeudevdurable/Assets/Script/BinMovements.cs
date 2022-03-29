using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BinMovements : MonoBehaviour
{
    [SerializeField] Rigidbody rb;
    private float screenWidth = Screen.width;
    private float moveSpeed = 300;

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
                MoveCharacter(1.0f);
            }
            // move left
            else if (Input.GetTouch(i).position.x < screenWidth / 2)
            {
                MoveCharacter(-1.0f);
            }
            i++;
        }

        // check if bin is outside of screenWidth
        if (binPos.x < 50)
        {
            transform.position = new Vector3(-2, 1, 0);
            rb.velocity = Vector3.zero;
        }

        else if (binPos.x > screenWidth - 50)
        {
            transform.position = new Vector3(2, 1, 0);
            rb.velocity = Vector3.zero;
        }
    }

    private void MoveCharacter(float input)
    {
        rb.AddForce(new Vector2(input * moveSpeed * Time.deltaTime, 0));
    }

    // Quand un object entre dans le boxCollider de la poubelle
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "recyclable")
        {
            // incrémente compteur de 1 pt
        }
        else
        {
            // perdre une vie ou faire descendre de x sec le compteur
        }
    }
}
