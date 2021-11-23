using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Inheritence
public class Dog : Animal
{
    // Start is called before the first frame update
    void Start()
    {
        jumpingPower = 10;
        animalRb = GetComponent<Rigidbody>();
        Name = "tik";
        movementSpeed = 5;
        //InitializeAnimal(10, GetComponent<Rigidbody>());
    }

    // Update is called once per frame
    void Update()
    {
        //abstraction
        if (Input.GetKeyDown(KeyCode.Space))
        {
            jump();
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            MoveForward();
        }
    }
    
}
