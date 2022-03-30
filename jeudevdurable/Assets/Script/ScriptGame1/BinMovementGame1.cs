using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BinMovementGame1 : MonoBehaviour
{
    [SerializeField] TimerGame1 timer;
    private readonly float screenWidth = Screen.width;

    private void Update()
    {
        /*
         *  If there is someone touching the screen
         *  Follow the touch while it is not release
         *  If it moved on the screen
         *  Calculate the longer of the move 
         *  If it goes out of the screen limits, stop it with limits value
         *  Then move the object with a 2D vector
         */
        if (Input.touchCount > 0)               
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Moved)
            {
                var abscisse = transform.position.x + touch.deltaPosition.x * 0.005f;
                Debug.Log(abscisse);
                if (abscisse > 2)
                {
                    abscisse = 2;
                }
                if (abscisse < -2)
                {
                    abscisse = -2;
                }
                transform.position = new Vector2(abscisse, transform.position.y);
            }
        }
    }

    // If an object "collid" (Get onto) the bin
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("recyclable"))
        {
            Destroy(collision.gameObject);
            timer.score++;
            timer.time += 1; 
        }
        else
        {
            Destroy(collision.gameObject);
            timer.lives--;
        }
    }

}
