
using UnityEngine;


[CreateAssetMenu(fileName = "New obstacle data", menuName = "Obstacle")]
public class Spawnable : ScriptableObject
{
    [SerializeField] private int lanes;
    public int Lanes { get => lanes; }
    [SerializeField] private GameObject prefab;
    public GameObject Prefab { get => prefab; }
}
