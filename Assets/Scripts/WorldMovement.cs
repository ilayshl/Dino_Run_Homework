using UnityEngine;

public class WorldMovement : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 10;

    void Update()
    {
        transform.position -= new Vector3(0, 0, moveSpeed * Time.deltaTime);
    }
}
