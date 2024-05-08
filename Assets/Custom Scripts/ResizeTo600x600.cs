using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResizeTo600x600 : MonoBehaviour
{
    public void ResizeTo600Square(GameObject objectToResize)
    {
        RectTransform rt = objectToResize.GetComponent<RectTransform>();
        rt.sizeDelta = new Vector2(600, 600);
    }
}
