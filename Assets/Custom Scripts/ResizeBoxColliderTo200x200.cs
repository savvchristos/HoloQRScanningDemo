using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResizeBoxColliderTo200x200 : MonoBehaviour
{
    public void ResizeBoxCollider(GameObject obj)
    {
        obj.GetComponent<BoxCollider>().transform.Translate(200, 200, 27);
    }
}
