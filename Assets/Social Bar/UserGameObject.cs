using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UserGameObject : MonoBehaviour
{
    public TextMeshProUGUI username, message;
    public Image pfp;

    public User user;

    private void Awake()
    {
        username.text = user.username;
        message.text = user.message;
        pfp.sprite = user.pfp;
    }
}
