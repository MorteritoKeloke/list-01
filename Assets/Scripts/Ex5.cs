using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex5 : MonoBehaviour
{
    public int num1;
    public int num2;
    // Start is called before the first frame update
    void Start()
    {
        if (num1>num2)
        {
            Debug.Log($"{num1} is greater than {num2}");
        }
        else
        {
            Debug.Log($"{num1} is lesser than {num2}");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
