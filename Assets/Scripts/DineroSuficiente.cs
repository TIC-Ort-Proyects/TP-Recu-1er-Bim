using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DineroSuficiente : MonoBehaviour
{

    public float money = 0;
    public float price1 = 0;
    public float price2 = 0;

    // Start is called before the first frame update
    void Start()
    {
        if (money == price1+price2)
        {
            Debug.Log("Te alcanza para pagar justo");
        }
        else if (money > price1+price2)
        {
            Debug.Log("Tienes dinero de sobra para pagar");
        }
        else
        {
            Debug.Log("No tienes dinero sufiente");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
