using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI countdownText;

    public void ChangeText(string value)
    {
        countdownText.text = value;
    }
}
