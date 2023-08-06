using UnityEngine;

public class Shop : MonoBehaviour
{
    public TutterBlueprint standardTurret;
    public TutterBlueprint atherTurret;
    public TutterBlueprint laserTurret;

    BuildManager buildManager;

    void Start()
    {
        buildManager = BuildManager.instance;
    }

    public void SelectStandardTurret ()
    {
        Debug.Log("Standard!!");
        buildManager.SelectTurretToBuild(standardTurret);
    }

    public void SelectAnotherTurret()
    {
        Debug.Log("Another!!");
        buildManager.SelectTurretToBuild(atherTurret);
    }

    public void SelectLaserTurret()
    {
        Debug.Log("Laser!!");
        buildManager.SelectTurretToBuild(laserTurret);
    }
}
