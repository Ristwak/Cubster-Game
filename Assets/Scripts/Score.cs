
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public Transform player;
    public TextMeshProUGUI scoreText;

    private void Update()
    {
        if (player == null || scoreText == null)
            return;

        float score = Mathf.Max(0f, player.position.z);

        scoreText.text = score.ToString("0");
    }
}
