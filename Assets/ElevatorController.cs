using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorController : MonoBehaviour
{

	public enum Going { UP, DOWN };

	public Transform bottom;
	public Transform top;

	public float speed = 3f;

	private Going going = Going.DOWN;
	private float progress = 0f;

	void FixedUpdate()
	{
		if(progress <= 1)
		{
			progress += speed * Time.deltaTime;

			if(going == Going.DOWN)
			{
				transform.position = Vector3.Lerp(top.position, bottom.position, progress);
			} else {
				transform.position = Vector3.Lerp(bottom.position, top.position, progress);
			}
		}
	}

	public void CallElevator(Going going){
		if(going == Going.DOWN)
		{
			if(progress == 1)
			{
				going = Going.UP;
				progress = 0;
			}
		}
		else if(going == Going.UP)
		{
			if(progress == 1)
			{
				going = Going.DOWN;
				progress = 0;
			}
		}
	}
}
