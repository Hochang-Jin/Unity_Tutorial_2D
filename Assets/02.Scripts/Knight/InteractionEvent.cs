using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionEvent : MonoBehaviour
{
    public enum InteractionType {SIGN, DOOR, NPC, BENCH}
    public InteractionType interactionType;

    public FadeRoutine fadeRoutine;
    
    public GameObject popup;

    public GameObject map;
    public GameObject house;

    public Vector3 inDoorPos, outDoorPos;
    public bool isHouse;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Interaction(other.transform);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            popup.SetActive(false);
        }
    }


    void Interaction(Transform player)
    {
        switch (interactionType)
        {
            case InteractionType.SIGN:
                popup.SetActive(true);
                break;
            case InteractionType.DOOR:
                StartCoroutine(DoorRoutine(player));
                break;
            case InteractionType.NPC:
                popup.SetActive(true);
                break;
            case InteractionType.BENCH:
                popup.SetActive(true);
                break;
            default:
                throw new ArgumentOutOfRangeException();
        }
    }

    IEnumerator DoorRoutine(Transform player)
    {
        yield return StartCoroutine(fadeRoutine.Fade(3f, Color.black, true));
        
        // 위치 조정 
        var pos = isHouse ? outDoorPos : inDoorPos;
        player.transform.position = pos;
        //뷰 조정
        map.SetActive(isHouse);
        house.SetActive(!isHouse);
        isHouse = !isHouse;
        yield return new WaitForSeconds(1f);
        
        yield return StartCoroutine(fadeRoutine.Fade(1f, Color.black, false));
        
    }
}
