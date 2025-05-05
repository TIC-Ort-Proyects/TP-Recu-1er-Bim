using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumeroMayor : MonoBehaviour
{

    public int numero1;
    public int numero2;

    // Start is called before the first frame update
    void Start()
    {
        if (numero1 == numero2)
        {
            Debug.Log($"Los números ingresados son iguales");
        }
        else if (numero1 > numero2)
        {
            Debug.Log($"El mayor de los dos números ingresados es {numero1}");
        }
        else if (numero1 < numero2)
        {
            Debug.Log($"El mayor de los dos números ingresados es {numero2}");
        }
        else
        {
            Debug.LogError("Numeros ingresados invalidos");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
