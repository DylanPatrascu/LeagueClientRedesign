using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class SocialButton : MonoBehaviour
{
    public GameObject panel;
    public bool isUserButton;

    private void Start()
    {
        if (isUserButton)
        {
            Button button = GetComponent<Button>();
            EventSystem.current.SetSelectedGameObject(button.gameObject);
            button.onClick.Invoke();
        }
    }

    public void turnOn()
    {
        
        panel.SetActive(true);
    }

    public void turnOff()
    {
        panel.SetActive(false);
    }
}
