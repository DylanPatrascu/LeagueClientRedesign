using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ChampionDetailManager : MonoBehaviour
{
    public static ChampionDetailManager Instance;

    public GameObject detailPanel;
    public Image splashArtImage;
    public TextMeshProUGUI bioText;
    public Button backButton;

    public Image statusImage;
    public Sprite ownedSprite;
    public Sprite unlockSprite;
    public Image nameImage;

    void Awake()
    {
        Instance = this;
        detailPanel.SetActive(false);
        backButton.onClick.AddListener(ReturnToGrid);


    }

    public void ShowChampionDetail(ChampionData data)
    {
        splashArtImage.sprite = data.splashArt;
        bioText.text = data.bio;
        nameImage.sprite = data.nameImage;
        nameImage.SetNativeSize();
        float fixedHeight = 60f;
        float aspect = nameImage.sprite.rect.width / nameImage.sprite.rect.height;
        nameImage.rectTransform.sizeDelta = new Vector2(fixedHeight * aspect, fixedHeight);


        statusImage.sprite = data.isPurchased ? ownedSprite : unlockSprite;

        detailPanel.SetActive(true);
        ToggleGrid(false);
    }

    public void ReturnToGrid()
    {
        detailPanel.SetActive(false);
        ToggleGrid(true);
    }

    void ToggleGrid(bool isVisible)
    {
        foreach (Transform child in transform)
        {
            if (child.name != "MenuBar" && child.name != "ChampionDetailPanel")
            {
                child.gameObject.SetActive(isVisible);
            }
        }
    }
}
