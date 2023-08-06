using UnityEngine;

[System.Serializable]
public class TutterBlueprint
{
    public GameObject prefab;
    public int cost;

    public int upgradeCost;
    public GameObject upgradePrefab;

    public int GetSellAmount()
    {
        return cost / 2;
    }
}
