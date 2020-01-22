using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorRaycast : MonoBehaviour
{
    public LayerMask buttonLayer;

    Transform playerView;

    void Start()
    {
        if (playerView == null)
        {
            Camera mainCamera = Camera.main;
            if (mainCamera != null)
                playerView = mainCamera.gameObject.transform;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Physics.Raycast(playerView.position, playerView.forward, out RaycastHit hit, 1000, buttonLayer))
        {
            GameObject hitObject = hit.collider.gameObject;
            if (hitObject.TryGetComponent<ElevatorButton>(out ElevatorButton button))
            {
                button.OnRayHit();
            }
        }
    }
}
