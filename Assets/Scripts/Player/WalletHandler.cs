using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalletHandler : MonoBehaviour
{
    private int _coinsAmount;

    private void Start()
    {
        _coinsAmount = 0;
    }

    public void AddCoin()
    {
        _coinsAmount++;
    }
}
