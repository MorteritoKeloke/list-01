using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex1 : MonoBehaviour
{
    public float x = 3;
    public float y = 4;
    public float z = 7;
    private float result;
    // Start is called before the first frame update
    void Start()
    {
        result = x + y + z;
        Debug.Log($"The result is {result}");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
