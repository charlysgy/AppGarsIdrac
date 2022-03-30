using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class SpawnObjectGame1 : MonoBehaviour
{

    [SerializeField] GameObject[] gameObjects;
    private System.Random rand = new System.Random();
    private int index;
    private List<GameObject> used = new List<GameObject>();
    private GameObject currentProj;

    // Start is called before the first frame update
    void Start()
    {
        index = gameObjects.Length;
        InstantiateObject();
    }

    // Update is called once per frame
    void Update()
    {
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
        currentProj.transform.position = new Vector3(rand.Next(-2, 2), transform.position.y);
    }
}
