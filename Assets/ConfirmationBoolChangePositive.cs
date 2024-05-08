using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConfirmationBoolChangePositive : MonoBehaviour
{
    public GameObject gameobjectWithBool;
    [SerializeField]
    private GameObject SmartiaS67;

    [SerializeField]
    private GameObject SupremeS500;

    [SerializeField]
    private GameObject SupremeF85;

    public void ChangeBoolToTrue()
    {
        gameobjectWithBool.GetComponent<QRCodeDisplayController>().confirmation = true;
        if (gameobjectWithBool.GetComponent<QRCodeDisplayController>().lastSeenCode.Data == "https://SMARTIAS67.GR")
        {
            //enable smartia ui
            SmartiaS67.SetActive(true);
        }
        else if (gameobjectWithBool.GetComponent<QRCodeDisplayController>().lastSeenCode.Data == "https://SUPREMES500.GR")
        {
            //enable SUPREMES500 ui
        }
        else if (gameobjectWithBool.GetComponent<QRCodeDisplayController>().lastSeenCode.Data == "https://SUPREMEF85.GR")
        {
            //enable SUPREMEF85 ui
        }
    }
}
