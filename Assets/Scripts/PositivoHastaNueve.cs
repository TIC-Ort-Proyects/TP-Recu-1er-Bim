using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositivoHastaNueve : MonoBehaviour
{

    public int number = 0;

    // Start is called before the first frame update
    void Start()
    {
        if (number < 10 && number > 0)
        {
            Debug.Log("El numero cumple con las condiciones");
        }
        else
        {
            Debug.Log("El numero no cumple con las condiciones");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
