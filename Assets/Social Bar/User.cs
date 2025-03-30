using UnityEngine;

[CreateAssetMenu(fileName = "NewUser", menuName = "User")]
public class User : ScriptableObject
{
    public string username, message;
    public Sprite pfp;
}
