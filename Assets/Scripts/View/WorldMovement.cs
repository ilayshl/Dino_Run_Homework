using UnityEngine;

public class WorldMovement : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 10;

    private const float OBJECT_WIDTH = 4.61f;

    void Update()
    {
        MoveForward();
        CheckIfPassedCamera();
    }

    private void MoveForward()
    {
        transform.position -= new Vector3(0, 0, moveSpeed * Time.deltaTime);
    }

    private void CheckIfPassedCamera()
    {
        if (transform.position.z < Camera.main.transform.position.z)
        {
        Vector3 newPosition = new();
        float distanceToMove = 0;
            foreach (Transform tube in transform.parent)
            {
                float distanceFromTube = Vector3.Distance(transform.position, tube.position);
                if (distanceFromTube > distanceToMove)
                {
                    distanceToMove = distanceFromTube;
                    Debug.Log($"DistanceCalculate was set to {distanceToMove}");
                    newPosition = tube.position;
                }
            }
            transform.position = newPosition + new Vector3(0, 0, OBJECT_WIDTH);
            Debug.Log($"{transform.name} has moved back to {newPosition.z}");
        }
    }
}
