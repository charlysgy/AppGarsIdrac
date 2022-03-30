using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class SpawnObjectGame2 : MonoBehaviour
{
    [SerializeField] GameObject[] gameObjects;
    private System.Random rand = new System.Random();
    private int index;
    private List<GameObject> used = new List<GameObject>();
    private GameObject currentProj;

    //start is called before the first frame update
    private void Start()
    {
        index = gameObjects.Length;
        InstantiateObject();
    }

    private void Update()
    {
        // reInstantiate a projectile when the previous is dead
        if (currentProj == null)
        {
            InstantiateObject();
        }
    }

    //Instantiate a random gameObject in gameObjects
    private void InstantiateObject()
    {
        int i = 0;
        while (true)
        {
            i = rand.Next(0, index);
            if (!used.Contains(gameObjects[i]))
            {
                break;
            }
        }
        used.Add(gameObjects[i]);
        if (used.Count == gameObjects.Length)
        {
            used.Clear();
        }
        currentProj = Instantiate(gameObjects[i], transform);
    }
}
