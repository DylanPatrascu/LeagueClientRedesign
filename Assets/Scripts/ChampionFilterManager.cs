using System.Collections.Generic;
using UnityEngine;

public class ChampionFilterManager : MonoBehaviour
{
    public static ChampionFilterManager Instance;

    public ChampionGridManager gridManager;

    private HashSet<string> activeRoles = new HashSet<string>();

    void Awake()
    {
        Instance = this;
    }

    public void ToggleFilter(string role, bool isActive)
    {
        if (isActive)
            activeRoles.Add(role);
        else
            activeRoles.Remove(role);

        ApplyFilter();
    }

    void ApplyFilter()
    {
        if (gridManager == null) return;

        foreach (Transform child in gridManager.contentParent)
        {
            ChampionDisplay display = child.GetComponent<ChampionDisplay>();
            if (display != null)
            {
                string champRole = display.GetRole();
                bool shouldShow = (activeRoles.Count == 0) || activeRoles.Contains(champRole);
                child.gameObject.SetActive(shouldShow);
            }
        }
    }
}
