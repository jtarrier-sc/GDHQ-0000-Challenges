using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    /// <summary>
    /// Create a program that allows you to enter your age, sex, and location into
    /// the inspector. When you press the space key, it should print out the values.
    /// You should be able to change these values at runtime. Example Print: "25 M Atlanta"
    /// </summary>

    // Variable to contain your age
    public int myAge = 25;

    // Variable to contain your sex
    public string mySex = "M";

    // Variable to contain your location
    public string myLocation = "Atlanta";

    // Start is called before the first frame update
    void Start()
    {
        // When the space key is pressed, print out the values. Example Print: "25 M Atlanta"
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
