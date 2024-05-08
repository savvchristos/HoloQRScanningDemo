using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResizeBoxColliderTo32x32 : MonoBehaviour
{
    public void ResizeBoxCollider(GameObject obj)
    {
        obj.GetComponent<BoxCollider>().transform.Translate(32, 32, 27);
    }
}
