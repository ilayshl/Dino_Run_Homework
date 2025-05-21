using UnityEngine;

/// <summary>
/// Spins the fucker
/// </summary>
public class SpinningMovement : MonoBehaviour
{

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
        map.Rotate(0, 0, _playerHorzMovement * rotationSpeed * Time.deltaTime);
    }
}
