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
    private GameObject SupremeSF85;

    public void ChangeBoolToTrue()
    {
        gameobjectWithBool.GetComponent<QRCodeDisplayController>().confirmation = true;
        if (gameobjectWithBool.GetComponent<QRCodeDisplayController>().lastSeenCode.Data == "https://SMARTIAS67.GR")
        {
            //enable smartia ui
            SmartiaS67.SetActive(true);
            SupremeS500.SetActive(false);
            SupremeSF85.SetActive(false);
        }
        else if (gameobjectWithBool.GetComponent<QRCodeDisplayController>().lastSeenCode.Data == "https://SUPREMES500.GR")
        {
            //enable SUPREMES500 ui
            SupremeS500.SetActive(true);
            SmartiaS67.SetActive(false);
            SupremeSF85.SetActive(false);
        }
        else if (gameobjectWithBool.GetComponent<QRCodeDisplayController>().lastSeenCode.Data == "https://SUPREMEF85.GR")
        {
            //enable SUPREMESF85 ui
            SupremeS500.SetActive(false);
            SmartiaS67.SetActive(false);
            SupremeSF85.SetActive(true);
        }
    }
}
