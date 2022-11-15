using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex10 : MonoBehaviour
{
    //private variable to do a loop
    private int x;
    
    public int y;
    private int result;
    // Start is called before the first frame update
    void Start()
    {
        for(int x=0; x < 11; x++)
        {
            result = x * y;
            Debug.Log ($"{y} * {x} = {result}");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
