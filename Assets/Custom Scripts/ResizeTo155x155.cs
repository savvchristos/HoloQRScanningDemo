using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResizeTo155x155 : MonoBehaviour
{
    public void ResizeTo155Square(GameObject objectToResize)
    {
        RectTransform rt = objectToResize.GetComponent<RectTransform>();
        rt.sizeDelta = new Vector2(145, 145);
    }
}
