using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class Amir_PlayerMovement : MonoBehaviour
{

    [SerializeField] private float rotationSpeed;
    [SerializeField] private Transform toPosition;
    [SerializeField] private Transform toPosition2;

    private Vector3 startPos;
    private Quaternion startRot;

    private float _playerHorzMovement;

    private void Start()
    {
        startPos = transform.position;
        startRot = transform.rotation;
    }

    private void Update()
    {
        UpdatePlayerInput();
    }


    private void UpdatePlayerInput()
    {
        float whereTo = Input.GetAxis("Horizontal");
        MoveTo(whereTo);
    }

    private void MoveTo(float whereTo)
    {
        if (Mathf.Abs(whereTo) > 0.1)
        {
            if (whereTo > 0)
            {
                var xPos = Mathf.InverseLerp(transform.position.x, toPosition.position.x, rotationSpeed * Time.deltaTime);
                var yPos = Mathf.InverseLerp(transform.position.y, toPosition.position.y, rotationSpeed * Time.deltaTime);

                var xRot = Mathf.InverseLerp(transform.rotation.x, toPosition.rotation.x, rotationSpeed * Time.deltaTime);
                var yRot = Mathf.InverseLerp(transform.rotation.y, toPosition.rotation.y, rotationSpeed * Time.deltaTime);

                transform.position = new Vector3(xPos, yPos, transform.position.z);
                transform.rotation = Quaternion.Euler(xRot, yRot, transform.rotation.z);
            }
            else
            {
                var xPos = Mathf.MoveTowards(transform.position.x, toPosition2.position.x, rotationSpeed * Time.deltaTime);
                var yPos = Mathf.MoveTowards(transform.position.y, toPosition2.position.y, rotationSpeed * Time.deltaTime);

                var xRot = Mathf.MoveTowards(transform.rotation.x, toPosition2.rotation.x, rotationSpeed * Time.deltaTime);
                var yRot = Mathf.MoveTowards(transform.rotation.y, toPosition2.rotation.y, rotationSpeed * Time.deltaTime);

                transform.position = new Vector3(xPos, yPos, transform.position.z);
                transform.rotation = Quaternion.Euler(xRot, yRot, transform.rotation.z);
            }
        }
        else if (whereTo == 0)
        {
            var xPos = Mathf.Lerp(transform.position.x, startPos.x, rotationSpeed * Time.deltaTime);
            var yPos = Mathf.Lerp(transform.position.y, startPos.y, rotationSpeed * Time.deltaTime);

            transform.position = new Vector3 (xPos, yPos, transform.position.z);
            
            Quaternion d = Quaternion.Lerp(transform.rotation, startRot, rotationSpeed * Time.deltaTime);
        }
    }
}
