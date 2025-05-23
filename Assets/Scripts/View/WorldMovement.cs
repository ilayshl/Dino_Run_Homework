using UnityEngine;

public class WorldMovement : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 10;
    [SerializeField] private Transform[] holders;

    private const float OBJECT_WIDTH = 4.61f;

    private GameObject spawnedObstacle;
    private Spawner spawner;

    void Awake()
    {
        spawner = GetComponentInParent<Spawner>();
    }

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
                    newPosition = tube.position;
                }
            }
            transform.position = newPosition + new Vector3(0, 0, OBJECT_WIDTH);
            if (spawnedObstacle != null)
            {
                Destroy(spawnedObstacle);
            }
            if (Random.Range(0, 100) > 50)
            {
                int index = Random.Range(0, holders.Length);
                spawnedObstacle = spawner.SpawnObstacle(holders[index].transform, 1);
            }
        }

    }
}
