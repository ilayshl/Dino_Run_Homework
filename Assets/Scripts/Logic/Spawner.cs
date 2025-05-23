using UnityEngine;

public class Spawner : MonoBehaviour
{
   [SerializeField] private Spawnable[] obstacles;
   [SerializeField] private Spawnable[] pickups;

   public GameObject SpawnObstacle(Transform parent, int lanesWidth)
   {
    GameObject obstacleToSpawn = null;
    foreach(var obstacle in obstacles)
    {
        if(lanesWidth == obstacle.Lanes)
        {
            obstacleToSpawn = obstacle.Prefab;
        }
    }
    if(obstacleToSpawn == null)
    {
        Debug.LogWarning("Error: no obstacle to spawn!");
        return null;
    }

    return Instantiate(obstacleToSpawn, parent.position, parent.rotation, parent);
   } 
}
