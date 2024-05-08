using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncreaseFontSize : MonoBehaviour
{
    public void IncreaseFontSizeFunction()
    {
        if (this.GetComponent<TextMesh>().fontSize < 18)
        {
            this.GetComponent<TextMesh>().fontSize++;
        }
        
    }

}
