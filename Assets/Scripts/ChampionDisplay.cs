using UnityEngine;
using UnityEngine.UI;

public class ChampionDisplay : MonoBehaviour
{
    public Image artImage;
    public GameObject lockOverlay;
    public RectTransform splashRect;
    private string role;
    public ChampionData championData;

    
    public void Setup(ChampionData data)
    {

        championData = data;
        
        artImage.sprite = data.splashArt;
        splashRect.localPosition = data.splashOffset;
        splashRect.localScale = Vector3.one * data.splashScale;

        if (lockOverlay != null)
            lockOverlay.SetActive(!data.isPurchased);

        Color color = data.isPurchased ? Color.white : new Color(0.25f, 0.25f, 0.25f, 1f);
        artImage.color = color;

        role = data.role;
    }

    public string GetRole()
    {
        return role;
    }

    public void OnClick()
    {
        ChampionDetailManager.Instance.ShowChampionDetail(championData);
    }

}
