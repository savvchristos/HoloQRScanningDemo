using System.Collections;
using System.Collections.Generic;
using MRTKExtensions.QRCodes;
using RealityCollective.ServiceFramework.Services;
using UnityEngine;

public class EnableCanvasFromQRCode : MonoBehaviour
{

    [SerializeField]
    private GameObject SmartiaS67;

    [SerializeField]
    private GameObject SupremeS500;

    [SerializeField]
    private GameObject SupremeF85;



    public void EnableCanvasFromQRCodeFunction(QRInfo codeReceived)
    {
        if (codeReceived.Data == "https://SMARTIAS67.GR")
        {
            //enable smartia ui
            SmartiaS67.SetActive(true);
        }
        else if (codeReceived.Data == "https://SUPREMES500.GR")
        {
            //enable SUPREMES500 ui
        }
        else if (codeReceived.Data == "https://SUPREMEF85.GR")
        {
            //enable SUPREMEF85 ui
        }
    }
}
