using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public int X; // X position (optional, depends on UI layout)
    public int Y; // Y position (optional)
    
    private Text scoreText;

    private void Awake()
    {
        // Create a Canvas if not already present
        Canvas canvas = FindObjectOfType<Canvas>();
        if (canvas == null)
        {
            GameObject canvasObj = new GameObject("Canvas");
            canvas = canvasObj.AddComponent<Canvas>();
            canvas.renderMode = RenderMode.ScreenSpaceOverlay;
            canvasObj.AddComponent<CanvasScaler>();
            canvasObj.AddComponent<GraphicRaycaster>();
        }

        // Create a Text object
        GameObject textObj = new GameObject("ScoreText");
        textObj.transform.SetParent(canvas.transform);

        scoreText = textObj.AddComponent<Text>();
        scoreText.font = Resources.GetBuiltinResource<Font>("Arial.ttf");
        scoreText.fontSize = 60;
        scoreText.alignment = TextAnchor.MiddleCenter;
        scoreText.color = Color.white;

        // Optional: position the text
        RectTransform rectTransform = scoreText.GetComponent<RectTransform>();
        rectTransform.anchoredPosition = new Vector2(X, Y);
        rectTransform.sizeDelta = new Vector2(200, 100);
    }

    // Call this to update the score display
    public void Display(int score)
    {
        if (scoreText != null)
        {
            scoreText.text = score.ToString();
        }
    }
}
