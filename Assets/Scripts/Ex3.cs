using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex3 : MonoBehaviour
{
    public string name;
    public int age;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log($"Hello, {name} ! You're {age} years old");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
