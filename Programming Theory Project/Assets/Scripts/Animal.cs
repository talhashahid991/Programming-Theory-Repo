using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour
{
    public float jumpingPower;
    public Rigidbody animalRb;
    public float movementSpeed;
    [SerializeField] private string animalName;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   /* public void InitializeAnimal(float jumpingPower, Rigidbody animalRb)
    {
        jumpingPower = this.jumpingPower;
        animalRb = this.animalRb;
    }*/

    public virtual void jump()
    {
        animalRb.AddForce(Vector3.up * jumpingPower, ForceMode.Impulse);
    }

    public void MoveForward()
    {
        transform.Translate(Vector3.forward * movementSpeed);
    }
    public string Name   // property
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
