using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorController : MonoBehaviour
{

    public enum Direction { UP, DOWN };

    public Transform bottom;
    public Transform top;

    public float speed = 3f;

    private Direction direction = Direction.DOWN;
    private float progress = 0f;

    void FixedUpdate()
    {
        if (progress <= 1)
        {
            progress += speed * Time.deltaTime;

            if (direction == Direction.DOWN)
            {
                transform.position = Vector3.Lerp(top.position, bottom.position, progress);
            }
            else
            {
                transform.position = Vector3.Lerp(bottom.position, top.position, progress);
            }
        }
      
    }
    public void CallElevator(Direction dir)
    {

        if (dir == Direction.UP)
        {
           if(direction == Direction.DOWN)
            {
                direction = Direction.UP;
                progress = 1 - progress;
            }
        }
        else 
        {
            if(direction == Direction.UP)
            {
                direction = Direction.DOWN;
                progress = 1 - progress;
            }
        }
    }
}
