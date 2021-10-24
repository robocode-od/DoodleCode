using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalletHandler : MonoBehaviour
{
    private int _amount;

    private void Start()
    {
        _amount = 0;
    }

    public void AddCoin()
    {
        _amount++;
    }
}
