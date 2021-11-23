using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour
{
    public float jumpingPower;
    public Rigidbody animalRb;
    public float movementSpeed;
    [SerializeField] private string animalName; //encapsulation

    public virtual void jump()//polymorphism
    {
        animalRb.AddForce(Vector3.up * jumpingPower, ForceMode.Impulse);
    }

    public void MoveForward() //abstraction
    {
        transform.Translate(Vector3.forward * movementSpeed);
    }
    public string Name   // property //encapsulation
    {
        get { return animalName; }   // get method
        set { 
            if (value.Length < 4)
            {
                animalName = value;
            }
            else
            {
                Debug.Log("Name characters should be less than 4.");
            }
            }  // set method
    }
}
