using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConfirmationBoolChangeNegative : MonoBehaviour
{
    public GameObject gameobjectWithBool;

    public void ChangeBoolToFalse()
    {
        gameobjectWithBool.GetComponent<QRCodeDisplayController>().confirmation = false;
    }
}
