using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConsolePrint : MonoBehaviour
{
    private string nameOfGameObject;
    private int i;
    // Start is called before the first frame update
    void Start()
    {
        nameOfGameObject = gameObject.name;
        i = 3;
        Debug.Log(i + "Hello");
    }

    // Update is called once per frame
    void Update()
    {
        i++;
        Debug.Log(nameOfGameObject + ':' + i);
    }
}
