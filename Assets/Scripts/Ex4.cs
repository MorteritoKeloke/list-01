using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex4 : MonoBehaviour
{
    public int currentYear;
    public int birthYear;
    private int age;
    // Start is called before the first frame update
    void Start()
    {
        age=currentYear-birthYear;
        Debug.Log($"If we are in the year {currentYear} and you were born in {birthYear}, you are {age} years old");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
