using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorController : MonoBehaviour
{

	enum Going { UP, DOWN };

	public Vector3 bottom;
	public Vector3 top;


	private Going going = Going.UP;
	private float progress = 0;

    void FixedUpdate()
    {
        
    }

	public void CallElevator(Going going){
		if(going == Going.DOWN)
		{
			if(progress == 1)
			{

			}
		}
	}
}
