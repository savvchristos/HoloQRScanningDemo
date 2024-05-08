using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResizeTo200x200 : MonoBehaviour
{
    public void ResizeTo200Square(GameObject objectToResize)
    {
        RectTransform rt = objectToResize.GetComponent<RectTransform>();
        rt.sizeDelta = new Vector2(200, 200);
    }
}
