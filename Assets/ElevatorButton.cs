using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorButton : MonoBehaviour
{

    public ElevatorController.Going direction;

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
            renderer.material.color = Color.red;
        }
    }

    public void OnRayHit(){
        rayHit = true;
    }
}
