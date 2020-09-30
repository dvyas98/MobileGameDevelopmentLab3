/*/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
Created BY :
Dhimant Vyas
101199558
Game Programming (T163)
DVSquareProductions.

Player Movement with Joystick and Tilt of the Spaceship using Euler Principle
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////*/
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Xml;
using UnityEngine;
using UnityEngine.Experimental.XR;
using UnityEngine.Events;

[System.Serializable]
public class Boundary
{
    public float xMin, xMax, yMin, yMax;

}

public class PlayerMove : MonoBehaviour
{
    private Transform _transform;

    public CharacterController controller;

    // Update is called once per frame
    public float _runSpeed = 10.0f;
    public float tilt = 3.0f;
    public Joystick joystick;
    public Boundary boundary;

    void Start()
    {
    }

    void Update()
    {
        float moveHorizontal = joystick.Horizontal;
        float moveVertical = joystick.Vertical;
        Vector3 movement = new Vector3(moveHorizontal, moveVertical, 0.0f);
        //rigidbody.Velocity = movement;
        GetComponent<Rigidbody>().velocity = movement * _runSpeed;
        // _horizontalMove = joystick.Horizontal * _runSpeed;
        GetComponent<Rigidbody>().position = new Vector3
        (
            Mathf.Clamp(GetComponent<Rigidbody>().position.x, boundary.xMin, boundary.xMax),
            Mathf.Clamp(GetComponent<Rigidbody>().position.y, boundary.yMin, boundary.yMax),
            0.0f
        );
        GetComponent<Rigidbody>().rotation = Quaternion.Euler(-180,GetComponent<Rigidbody>().velocity.x*-tilt,0.0f);

    }
}
