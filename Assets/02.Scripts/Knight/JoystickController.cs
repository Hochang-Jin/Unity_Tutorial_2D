using UnityEngine;
using UnityEngine.EventSystems;

public class JoystickController : MonoBehaviour, IPointerDownHandler, IDragHandler, IPointerUpHandler
{
    [SerializeField] private GameObject backgroundUI;
    [SerializeField] private GameObject handlerUI;
    
    private float MAXDISTANCE = 50f;
    
    private Vector2 startPos, currentPos;
    
    [SerializeField] private KnightController_Joystick knightControllerJoystick;
    
    public void OnPointerDown(PointerEventData eventData)
    {
        startPos = eventData.position;
        backgroundUI.transform.position = startPos;
        backgroundUI.SetActive(true);
    }

    public void OnDrag(PointerEventData eventData)
    {
        currentPos = eventData.position;
        Vector2 dragDir = currentPos - startPos;

        float distance = Mathf.Min(dragDir.magnitude, MAXDISTANCE); // 최대값을 넘기는지 확인, 최대값을 넘기면 최대값으로
        
        handlerUI.transform.position = startPos + dragDir.normalized * distance;
        
        knightControllerJoystick.InputJoystick(dragDir.x, dragDir.y);
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        knightControllerJoystick.InputJoystick(0, 0);
        handlerUI.transform.localPosition = Vector2.zero;
        backgroundUI.SetActive(false);
    }
}
