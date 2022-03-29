using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class spawnObject : MonoBehaviour
{
    [SerializeField] GameObject[] gameObjects;
    private System.Random rand = new System.Random();
    private int rdn;
    private int index;
    private GameObject currentProj;

    private void Start()
    {
        index = gameObjects.Length;
        rdn = rand.Next(0, index);
        InstantiateObject(rdn);
    }

    private void Update()
    {
        // reInstantiate a projectile when the previous is dead
        if (currentProj == null)
        {
            rdn = rand.Next(0, index - 1);
            InstantiateObject(rdn);
        }
    }

    //Instantiate a random gameObject in gameObjects
    private void InstantiateObject(int i)
    {
        currentProj = Instantiate(gameObjects[i], this.transform);
    }
}
