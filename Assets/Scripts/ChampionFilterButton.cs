using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ChampionFilterButton : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public string filterRole;
    public Sprite whiteSprite;
    public Sprite goldSprite;

    public float hoverScale = 1.15f;
    public float selectedScale = 1.25f;
    public float normalScale = 1.0f;

    private bool isSelected = false;
    private Image image;
    private Vector3 originalScale;

    void Start()
    {
        image = GetComponent<Image>();
        originalScale = Vector3.one * normalScale;
        transform.localScale = originalScale;
        image.sprite = whiteSprite;

        GetComponent<Button>().onClick.AddListener(OnClick);
    }

    public void OnClick()
    {
        isSelected = !isSelected;

        if (isSelected)
        {
            transform.localScale = Vector3.one * selectedScale;
            image.sprite = goldSprite;
        }
        else
        {
            transform.localScale = Vector3.one * normalScale;
            image.sprite = whiteSprite;
        }

        ChampionFilterManager.Instance.ToggleFilter(filterRole, isSelected);
    }


    public void OnPointerEnter(PointerEventData eventData)
    {
        if (!isSelected) {
            transform.localScale = Vector3.one * hoverScale;
        }
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        if (!isSelected) {
            transform.localScale = Vector3.one * normalScale;
        }
    }
}
