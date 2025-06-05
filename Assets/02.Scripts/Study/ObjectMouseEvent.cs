using System;
using UnityEngine;

public class ObjectMouseEvent : MonoBehaviour
{
    void OnMouseEnter()
    {
        Debug.Log("Mouse Enter");
    }

    private void OnMouseOver()
    {
        Debug.Log("Mouse Over");
    }

    void OnMouseDown()
    {
        Debug.Log("Mouse Down");
    }

    private void OnMouseDrag()
    {
        Debug.Log("Mouse Drag");
    }

    void OnMouseExit()
    {
        Debug.Log("Mouse Exit");
    }

    private void OnMouseUpAsButton()
    {
        Debug.Log("Mouse UpAsButton");
    }

    void OnMouseUp()
    {
        Debug.Log("Mouse Up");
    }
}