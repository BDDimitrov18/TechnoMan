using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomChanger : MonoBehaviour
{
    private Vector2 position;
    private Vector2 size;
    private Vector3 rotation;
    public void MakeChange(GameObject temp,GameObject parent)
    {
        foreach (Transform child in transform)
        {
            Destroy(child.gameObject);
        }
        foreach (Transform child in temp.transform)
        {
            position = child.position;
            size = child.localScale;
            Instantiate(child.gameObject,position,child.rotation,parent.transform);
        }
    }
}
