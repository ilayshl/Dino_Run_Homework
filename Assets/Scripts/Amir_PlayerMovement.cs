using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class Amir_PlayerMovement : MonoBehaviour
{

    [SerializeField] private float rotationSpeed;
    [SerializeField] private float slerpTo = 35f;

    private Quaternion _startRot;


    private float _playerHorzMovement;

    private void Start()
    {
        _startRot = transform.rotation;
    }

    private void Update()
    {
        UpdatePlayerInput();
    }

    private void UpdatePlayerInput()
    {
        float playerInput = Input.GetAxis("Horizontal");
        RotatePlayer(playerInput);
    }

    private void RotatePlayer(float playerInput)
    {
        if (playerInput == 0)
        {
            Quaternion goHome = Quaternion.Slerp(transform.rotation, _startRot, rotationSpeed * Time.deltaTime);
            transform.rotation = goHome;
        }
        else if(Mathf.Abs(playerInput) > 0.01f)
        {
            var whichWay = playerInput * slerpTo * -1;
            Quaternion fitIn = Quaternion.Euler(0,0,whichWay);

            Quaternion goTo = Quaternion.Slerp(transform.rotation, fitIn, rotationSpeed * Time.deltaTime);

            transform.rotation = goTo;
        }
    }
}
