using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DropdownEnableGameobject : MonoBehaviour
{
    private TMPro.TMP_Dropdown dropdown;
    public GameObject canvasSmartiaS67;
    public GameObject canvasSupremeS500;
    public GameObject canvasSupremeF87;

    public void EnableOnValueChange()
    {
        if (dropdown.value == 1)
        {
            canvasSmartiaS67.SetActive(true);
        }
        else if (dropdown.value == 2)
        {
            canvasSupremeS500.SetActive(true);
        }
        else if (dropdown.value == 3)
        {
            canvasSupremeF87.SetActive(true);
        }
    }
}
