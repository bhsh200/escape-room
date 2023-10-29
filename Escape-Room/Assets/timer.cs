using UnityEngine;
using TMPro;

public class TimerDisplay : MonoBehaviour
{
    public TextMeshProUGUI Timer_Text;
    private float elapsedTime = 0f;

    void Update()
    {
        // Update the elapsed time
        elapsedTime += Time.deltaTime;

        // Format the time as HH:MM:SS
        int hours = Mathf.FloorToInt(elapsedTime / 3600);
        int minutes = Mathf.FloorToInt((elapsedTime % 3600) / 60);
        int seconds = Mathf.FloorToInt(elapsedTime % 60);

        // Update the TextMeshPro text
        Timer_Text.text = string.Format("Time: {0:D2}:{1:D2}:{2:D2}", hours, minutes, seconds);
    }
}
