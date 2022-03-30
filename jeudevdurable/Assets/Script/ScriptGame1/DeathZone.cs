using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathZone : MonoBehaviour
{

    [SerializeField] TimerGame1 timer;

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("recyclable"))
        {
            Destroy(collision.gameObject);
            timer.time -= 1;
            timer.lives--;
        }
        else
        {
            Destroy(collision.gameObject);
        }
    }
}
