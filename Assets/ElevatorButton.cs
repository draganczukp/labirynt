using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorButton : MonoBehaviour
{

    public ElevatorController.Direction dir;

    public ElevatorController Elevator;

    private bool rayHit = false;

    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Renderer renderer = GetComponent<Renderer>();
        if(rayHit)
        {
            renderer.material.SetColor("_Color", Color.red);

            if (Input.GetMouseButtonDown(0))
            {
                Elevator.CallElevator(dir);
                dir = dir == ElevatorController.Direction.UP
                    ? ElevatorController.Direction.DOWN
                    : ElevatorController.Direction.UP;
            }

        }else
        {
            renderer.material.SetColor("_Color", Color.blue);
        }

        rayHit = false;
    }

    public void OnRayHit(){
        rayHit = true;
    }

}
