using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class MoneyIU : MonoBehaviour
{
    public Text moneyText;

    // Update is called once per frame
    void Update()
    {
        moneyText.text = "$" + PlayerStats.Money.ToString(); 
    }
}
