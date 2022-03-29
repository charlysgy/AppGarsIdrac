using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BinsGame2 : MonoBehaviour
{
    [SerializeField] Timer timer;

    // attribution of points or penalities
    private void OnTriggerEnter(Collider collision)
    {
        if ((collision.tag == "green" && tag == "green") || (collision.tag == "yellow" && tag == "yellow"))
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
