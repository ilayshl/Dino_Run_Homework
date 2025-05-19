using UnityEngine;

public class SpinningMovement : MonoBehaviour
{
    /// <summary>
    /// spins the fucker
    /// </summary>
   
    [SerializeField] private Transform map;
    [SerializeField] private float rotationSpeed;

    private float _playerHorzMovement;


    private void Update()
    {
        UpdatePlayerInput();
    }

    private void UpdatePlayerInput()
    {
        _playerHorzMovement = Input.GetAxis("Horizontal") * -1f;
        transform.Rotate(0, _playerHorzMovement * rotationSpeed * Time.deltaTime, 0);
    }
}
