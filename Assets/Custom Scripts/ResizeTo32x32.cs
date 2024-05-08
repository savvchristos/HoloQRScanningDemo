using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResizeTo32x32 : MonoBehaviour
{
    public void ResizeTo32Square(GameObject objectToResize)
    {
        RectTransform rt = objectToResize.GetComponent<RectTransform>();
        rt.sizeDelta = new Vector2(32, 32);
    }
}
