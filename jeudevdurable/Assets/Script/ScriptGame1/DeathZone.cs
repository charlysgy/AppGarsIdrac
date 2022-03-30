using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathZone : MonoBehaviour
{

    [SerializeField] TimerGame1 timer;

    public void OnTriggerEnter(Collider collision)
    {
        if (collision.tag == ("recyclable"))
        {
            print("lose");
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
