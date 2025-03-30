using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GroupGameObject : MonoBehaviour
{
    public Group group;
    public Image pfp0, pfp1, pfp2;
    public TextMeshProUGUI groupName, message;

    private void Awake()
    {
        pfp0.sprite = group.users[0].pfp;
        pfp1.sprite = group.users[1].pfp;
        pfp2.sprite = group.users[2].pfp;

        groupName.text = group.groupName;
        message.text = group.users[group.messagingUserIndex].username
             + ": " + group.message;
    }


}
