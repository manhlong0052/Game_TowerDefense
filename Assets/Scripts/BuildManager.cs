using UnityEngine;
using System.Collections;

public class BuildManager : MonoBehaviour
{
    public static BuildManager instance;

    void Awake()
    {
        if (instance != null)
        {
            Debug.LogError("More than one BuildManager!");
        }

        instance = this;
    }

    public GameObject standardTurretPrefab;
    public GameObject anotherTurretPrefab;
    public GameObject laserTurretPrefab;

    public GameObject BuildEffect;
    public GameObject SellEffect;

    private TutterBlueprint turretToBuild;
    private Node selectedNode;

    public NodeIU nodeIU;

    public bool CanBuild { get { return turretToBuild != null; } }
    public bool HasMoney { get { return PlayerStats.Money >= turretToBuild.cost; } }

    public void SelectNode (Node node)
    {
        if (selectedNode == node)
        {
            DeselectNode();
            return;
        }

        selectedNode = node;
        turretToBuild = null;

        nodeIU.SetTarget(node);
    }

    public void DeselectNode ()
    {
        selectedNode = null;
        nodeIU.Hide();
    }

    public void SelectTurretToBuild(TutterBlueprint turret)
    {
        turretToBuild = turret;

        DeselectNode();
    }

    public TutterBlueprint GetTurretToBuild ()
    {
        return turretToBuild;
    }
}
