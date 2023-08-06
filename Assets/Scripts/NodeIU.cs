using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class NodeIU : MonoBehaviour
{
    public GameObject ui;

    public Text upgradeCost;
    public Button upgradeButton;

    public Text sellAmount;

    private Node target;

    public void SetTarget (Node t)
    {
        target = t;
        transform.position = target.GetBuildPosition();

        if (!target.isUpgraded)
        {
            upgradeCost.text = "$" + target.tutterBlueprint.upgradeCost;
            upgradeButton.interactable = true;
        }
        else
        {
            upgradeCost.text = "DONE";
            upgradeButton.interactable = false;

        }

        sellAmount.text = "$" + target.tutterBlueprint.GetSellAmount();

        ui.SetActive(true);
    }

    public void Hide ()
    {
        ui.SetActive(false);
    }

    public void Upgrade ()
    {
        target.UpgradeTurret();
        BuildManager.instance.DeselectNode();
    }

    public void Sell ()
    {
        target.turretSell();
        BuildManager.instance.DeselectNode();
    }
}
