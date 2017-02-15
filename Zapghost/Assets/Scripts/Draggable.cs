using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Draggable : MonoBehaviour, IBeginDragHandler,IDragHandler,IEndDragHandler{
    public GameObject Defender1;
    public GameObject d;

    public Transform parentToReturnTo = null;

    public void OnBeginDrag(PointerEventData eventData)
    {
        //Debug.Log("onbegindrag");
        //parentToReturnTo = this.transform.parent;
        //this.transform.SetParent(this.transform.parent.parent);
        //GetComponent<CanvasGroup>().blocksRaycasts = false;
        d = (GameObject) Instantiate(Defender1, transform.position, transform.rotation);
    }

   

    public void OnDrag(PointerEventData eventData)
    {
        //Debug.Log("onbegindrag");
        //this.transform.position = eventData.position;
        Vector3 mousePosition = new Vector3(Input.mousePosition.x,5,Input.mousePosition.y);
        Vector3 objPosition= Camera.main.ScreenToWorldPoint(mousePosition);
        d.transform.position = objPosition;
        
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        //Debug.Log("onbegindrag");
        if (true)
        {
            //this.transform.SetParent(parentToReturnTo);
            //GetComponent<CanvasGroup>().blocksRaycasts = true;
        }
        else
        {
            //Destroy(d);
        }
    }
}
