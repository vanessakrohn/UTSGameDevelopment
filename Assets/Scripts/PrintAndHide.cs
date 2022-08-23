using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    private int i = 3;
    public Renderer rend;
    private int randomVariable;

    // Start is called before the first frame update
    void Start()
    {
        randomVariable = Random.Range(200, 251);
    }

    // Update is called once per frame
    void Update()
    {
        i++;
        
        if (i == 100 && gameObject.CompareTag("Red"))
        {
            gameObject.SetActive(false);
        }
        
        else if (i == randomVariable && gameObject.CompareTag("Blue"))
        {
            rend.enabled = false;
        }
        
        Debug.Log(gameObject.name + ":" + i);
    }
}