using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex2 : MonoBehaviour
{
    public string name;
    public string city;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log($"Hello, {name} ! Welcome to {city}");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
