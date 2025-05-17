using UnityEngine;

[CreateAssetMenu(fileName = "New Obstacle", menuName = "Obstacle")]
public class Obstacle : ScriptableObject
{
    [SerializeField] private ObstacleLaneType designatedLane;
    public ObstacleLaneType DesignatedLane {get => designatedLane;}
    [SerializeField] private GameObject[] obstacleObjects;
    public GameObject[] ObstacleObjects {get => obstacleObjects;}
}
