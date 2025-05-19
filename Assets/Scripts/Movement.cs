using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private Transform map;
    
    [SerializeField] private AnimationCurve _curve;

    private float _playerHorzMovement;


    private void Update()
    {
        UpdatePlayerInput();
    }

    private void UpdatePlayerInput()
    {
        _playerHorzMovement = Input.GetAxis("Horizontal") * -1f;
    }

    private void FixedUpdate()
    {
        
    }

    void CameraMoveToPlayerPosition()
    {
        var normalizedMovement = _playerHorzMovement;
        
        
    }
}
