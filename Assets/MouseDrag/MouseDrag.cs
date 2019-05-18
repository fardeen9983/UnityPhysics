using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseDrag : MonoBehaviour
{
    Vector3 screenPoint,offset;
    private void OnMouseDown()
    {
        screenPoint = Camera.main.WorldToScreenPoint(Input.mousePosition);


        offset = Input.mousePosition - Camera.main.ScreenToWorldPoint(
            new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
    }
    private void OnMouseDrag()
    {
        Vector3 curPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition) + offset;
        transform.position = curPosition;
    }
}
