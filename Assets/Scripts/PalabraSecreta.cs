using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PalabraSecreta : MonoBehaviour
{

    public string secretWordInput;
    string secretWord = "domingo";

    // Start is called before the first frame update
    void Start()
    {
        if (secretWordInput == secretWord)
        {
            Debug.Log("Has adivinado la palabra");
        }
        else
        {
            Debug.Log("Palabra incorrecta");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
