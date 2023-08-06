using System.Collections;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public static int Money;
    public int startMoney = 400;

    public static int Lives;
    public int startLife = 20;

    public static int Rounds = 0;

    private void Start()
    {
        Money = startMoney;
        Lives = startLife;
    }
}
