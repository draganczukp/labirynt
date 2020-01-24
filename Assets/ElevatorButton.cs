using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorButton : MonoBehaviour
{

    public ElevatorController.Direction dir;

    public ElevatorController Elevator;

    private bool rayHit = false;

    private Renderer renderer;


    void Start()
    {
        renderer = GetComponent<Renderer>();
        renderer.material.color = Color.blue;
    }

    void OnMouseEnter()
    {
        renderer.material.color = Color.red;
    }

    void OnMouseExit()
    {
        renderer.material.color = Color.blue;
    }

    void FixedUpdate()
    {
        if(rayHit)
        {
            if (Input.GetMouseButtonDown(0))
            {
                Elevator.CallElevator(dir);
                dir = dir == ElevatorController.Direction.UP
                    ? ElevatorController.Direction.DOWN
                    : ElevatorController.Direction.UP;
            }

        }else
        {
        }

        rayHit = false;
    }

    public void OnRayHit(){
        rayHit = true;
    }

}
