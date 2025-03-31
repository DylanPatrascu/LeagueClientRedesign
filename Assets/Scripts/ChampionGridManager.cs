using System.Collections.Generic;
using UnityEngine;

public class ChampionGridManager : MonoBehaviour
{
    public Transform contentParent;
    public GameObject championPrefab;
    public List<ChampionData> allChampions = new List<ChampionData>();

    void Start()
    {
        PopulateGrid();
    }

    void PopulateGrid()
    {
        foreach (ChampionData data in allChampions)
        {
            GameObject champObj = Instantiate(championPrefab, contentParent);

            var display = champObj.GetComponent<ChampionDisplay>();
            if (display != null)
            {
                display.Setup(data);
            }
        }
    }
}
