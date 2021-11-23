using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat : Animal
{
    // Start is called before the first frame update
    void Start()
    {
        jumpingPower = 5;
        animalRb = GetComponent<Rigidbody>();
        Name = "Kitty"; //this should generate an error becase of setting condition
        movementSpeed = 5;
        //InitializeAnimal(20, GetComponent<Rigidbody>());
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            jump();
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            MoveForward();
        }
    }

    public override void jump()
    {
        animalRb.AddForce(Vector3.forward * jumpingPower , ForceMode.Impulse);
        base.jump();
    }
}
