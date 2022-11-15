using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex6 : MonoBehaviour
{
    public int day;
    // Start is called before the first frame update
    void Start()
    {
       if (day == 6 || day == 7)
    {
        Debug.Log($"Day {day} belongs to the weekend");
    } 
    else if (day < 1 || day > 7)
    {
        Debug.Log($"enter a valid number between 1-7 ");
    }
    else
    {
        Debug.Log($"Day {day} does not belong to the weekend");
    }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
