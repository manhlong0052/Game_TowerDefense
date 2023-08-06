using UnityEngine;
using UnityEngine.UI;

public class LiveIU : MonoBehaviour
{
    public Text LiveText;

    // Update is called once per frame
    void Update()
    {
        LiveText.text = PlayerStats.Lives.ToString() + " LIFES";
    }
}
