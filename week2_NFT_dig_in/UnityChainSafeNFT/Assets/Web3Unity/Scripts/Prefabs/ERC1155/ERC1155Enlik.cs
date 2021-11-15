using System.Collections;
using System.Numerics;
using System.Collections.Generic;
using UnityEngine;

public class ERC1155Enlik : MonoBehaviour
{
    public GameObject Sphere;
    async void Start()
    {
        string chain = "ethereum";
        string network = "ethereum";
        string contract = "0x495f947276749ce646f68ac8c248420045cb7b5e";
        // string account = "0x5202De376D93855703233C65E3E100c4e8f18eBe";
        string account = PlayerPrefs.GetString("Account");
        string tokenId = "52116219681920949879248076179330134446977715799947301246846144326674962972673";

        BigInteger balanceOf = await ERC1155.BalanceOf(chain, network, contract, account, tokenId);
        print(balanceOf);

        // if (balanceOf > 0)
        // {
        //     Sphere.GetComponent<Renderer>().material.SetColor("_Color", Color.red);
        // }
    }
}
