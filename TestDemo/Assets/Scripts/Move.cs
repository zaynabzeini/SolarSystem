using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour // make sure class name matches file name
{
    // Start is called before the first frame update  
    void Start()
    {
        // only called once, sets up all the game objects
    }

    // Update is called once per frame
    void Update()
    {
        // is called in every loop in unity

        /*
        Vector3 v1 = transform.position; // gets the current position of the cube
                // Vector3 is a class that consists of x, y, and z, which represents the points in the 3d dimension
                // transform is the labelled section in the object properties (under inspector) and has a feature "position" 
                // the position feature has 3 values for x, y, and z
                // it will know to get the properties of the cube bc this script will be manually dragged onto the object
        this.transform.position = v1 + new Vector3(1, 0, 0) * Time.deltaTime; // increments that position of the cube
                // multiplies it by Time to ensure it's the same speed on all devices that it runs on
        */

        transform.Rotate(Vector3.right * 25 * Time.deltaTime);
                // Vector3.right moves a Vector3 class object default (0,0,0) to the right, making it (1,0,0), as seen in the slides 
                // .Rotate takes the object and rotates it along that point a number of degrees
                // the 5 multiplied to the Vector3 object determines the speed
    }
}
