﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Draggable : MonoBehaviour, IBeginDragHandler,IDragHandler,IEndDragHandler{
    public GameObject Defender1;
    public GameObject d;
    public GameObject plane;

    LayerMask mask = 1 << 8;
    Ray clickRay;
    RaycastHit posPoint;
    RaycastHit clickPoint;
    public Transform parentToReturnTo = null;

    public void OnBeginDrag(PointerEventData eventData)
    {
        parentToReturnTo = this.transform;
        GetComponent<CanvasGroup>().blocksRaycasts = false;
        d = (GameObject) Instantiate(Defender1, transform.position, transform.rotation);
        d.transform.SetParent(parentToReturnTo);
    }

   

    public void OnDrag(PointerEventData eventData)
    {
        
        clickRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(clickRay, out clickPoint))
        {
            Physics.Raycast(clickRay, out posPoint, Mathf.Infinity, mask.value);
            Vector3 mouseMove = posPoint.point;
            d.transform.position = (new Vector3(mouseMove.x, (plane.transform.position.y + 5), mouseMove.z));
            //Debug.Log("input"+Input.mousePosition);
            Debug.Log("mousemove"+mouseMove);
            //Debug.Log("d"+d.transform.position);
        }
        else
        {
            d.transform.position = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y,360));
        }

    }

    public void OnEndDrag(PointerEventData eventData)
    {
        
        if (Physics.Raycast(clickRay, out clickPoint) && parentToReturnTo.childCount == 0)
        {
            
            d.transform.SetParent(parentToReturnTo);
            Vector3 pos = parentToReturnTo.transform.position;
            d.transform.position = new Vector3(pos.x, pos.y + 3,pos.z);
			Defender1 d1Script = d.GetComponent<Defender1> ();
			d1Script.StartFire ();
        }
        else
        {
            Destroy(d);
        }

        GetComponent<CanvasGroup>().blocksRaycasts = true;

    }
}
