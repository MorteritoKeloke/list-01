using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex9 : MonoBehaviour
{
    public int NumberCandies;
    public int people;
    private int result;
    private int leftoverCandies;
    // Start is called before the first frame update
    void Start()
    {
        result = NumberCandies / people;
        Debug.Log($"There's {result} candies for each person");
        leftoverCandies = NumberCandies % people;
        Debug.Log($"there's {leftoverCandies} leftover candies");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
