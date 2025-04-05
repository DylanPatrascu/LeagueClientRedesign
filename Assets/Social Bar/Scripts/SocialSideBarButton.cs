using UnityEngine;
using UnityEngine.UIElements;

public class SocialSideBarButton : MonoBehaviour
{
    public Vector3 onPos;
    public Vector3 offPos;
    public float smoothTime = 2f;

    RectTransform rectTransform;
    Vector3 velocity = Vector3.zero;
    bool onScreen = false, moving = false;

    Vector3 targetPos;

    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
    }

    private void Update()
    {
        Debug.Log(rectTransform.position);

        if (moving)
        {
            rectTransform.anchoredPosition =
                Vector3.SmoothDamp(rectTransform.anchoredPosition, targetPos,
                                   ref velocity, smoothTime);

            if (Vector3.Distance(rectTransform.anchoredPosition, targetPos) <= 1f)
            {
                velocity = Vector3.zero;
                moving = false;
            }
        }
    }

    public void pressButton()
    {
        onScreen = !onScreen;
        moving = true;
        targetPos = onScreen ? offPos : onPos;
    }

}
