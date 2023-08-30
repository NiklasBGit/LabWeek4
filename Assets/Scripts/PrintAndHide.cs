using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    private string nameOfGameObject;
    private int i;
    private int rndInt;

    public Renderer rend;
    // Start is called before the first frame update
    void Start()
    {
        nameOfGameObject = gameObject.name;
        i = 3;
        //System.Random rnd = new System.Random();
        rndInt = UnityEngine.Random.Range(150, 251);
    }

    // Update is called once per frame
    void Update()
    {
        i++;
        Debug.Log(nameOfGameObject + ':' + i);
        if (i == 100 && gameObject.tag == "Red")
        {
            gameObject.SetActive(false);
        }
        if (i == rndInt && gameObject.tag == "Blue")
        {
            rend = GetComponent<Renderer>();
            rend.enabled = false;
        }
    }
}
