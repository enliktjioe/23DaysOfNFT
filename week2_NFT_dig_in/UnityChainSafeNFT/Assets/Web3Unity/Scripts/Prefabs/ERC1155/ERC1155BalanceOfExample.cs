using System.Collections;
using System.Numerics;
using System.Collections.Generic;
using UnityEngine;

public class ERC1155BalanceOfExample : MonoBehaviour
{
    public GameObject Sphere;
    async void Start()
    {
        // string chain = "avalanche";
        // string network = "testnet";
        // string contract = "0xbDF2d708c6E4705824dC024187cd219da41C8c81";
        // string account = "0xdD4c825203f97984e7867F11eeCc813A036089D1";
        // string tokenId = "2";

        string chain = "ethereum";
        string network = "ethereum";
        string contract = "0x495f947276749ce646f68ac8c248420045cb7b5e";
        string account = PlayerPrefs.GetString("Account");
        string tokenId = "52116219681920949879248076179330134446977715799947301246846144326674962972673";

        BigInteger balanceOf = await ERC1155.BalanceOf(chain, network, contract, account, tokenId);
        print(balanceOf);

        if (balanceOf > 0)
        {
            Sphere.GetComponent<Renderer>().material.SetColor("_Color", Color.red);
        }
    }
}
