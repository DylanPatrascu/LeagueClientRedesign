using UnityEngine;

[System.Serializable]
public class ChampionData
{
    public string name;
    public Sprite splashArt;
    public string role;
    public bool isPurchased;

    public Vector2 splashOffset = Vector2.zero;
    public float splashScale = 1f;

    [TextArea(3, 5)]
    public string bio;

    public Sprite nameImage;
}
