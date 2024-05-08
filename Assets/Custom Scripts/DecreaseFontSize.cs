using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DecreaseFontSize : MonoBehaviour
{
    public void DecreaseFontSizeFunction()
    {
        if (this.GetComponent<TextMesh>().fontSize > 14)
        {
            this.GetComponent<TextMesh>().fontSize--;
        }
    }
}
