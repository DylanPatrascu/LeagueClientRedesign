using UnityEngine;

[CreateAssetMenu(fileName = "NewGroup", menuName = "Group")]
public class Group : ScriptableObject
{
    public User[] users;
    public int messagingUserIndex;
    public string groupName, message;
}
