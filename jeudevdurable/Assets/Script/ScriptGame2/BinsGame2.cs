using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BinsGame2 : MonoBehaviour
{
    [SerializeField] TimerGame2 timer;

    // attribution of points or penalities
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.tag == tag)
        {
            Destroy(collision.gameObject);
            timer.score++;
        }
        else
        {
            Destroy(collision.gameObject);
            timer.time--;
        }
    }
}
