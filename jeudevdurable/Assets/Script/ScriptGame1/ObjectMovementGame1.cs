using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMovementGame1 : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -6)
        {
            Destroy(gameObject);
        }
    }
}
