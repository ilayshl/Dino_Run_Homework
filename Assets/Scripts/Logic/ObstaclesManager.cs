using UnityEngine;

public class ObstaclesManager : MonoBehaviour
{
    [SerializeField] private Obstacle[] obstaclePool;


    public void SpawnObstacle(ObstacleLaneType type)
    {
        for(int i = 0; i < obstaclePool.Length; i++)
        {
            if(obstaclePool[i].DesignatedLane == type)
            {
                Instantiate(obstaclePool[i]);
                return;
            }
        }
    }
}
