using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SinCeros : MonoBehaviour
{

    public float num1 = 0;
    public float num2 = 0;

    // Start is called before the first frame update
    void Start()
    {
        if (num2 != 0)
        {
            Debug.Log($"{num1}/{num2}={num1 / num2}");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
