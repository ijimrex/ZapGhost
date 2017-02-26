<<<<<<< HEAD
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

        //Debug.Log("copy");
        d.transform.SetParent(parentToReturnTo);
    }

   

    public void OnDrag(PointerEventData eventData)
    {
        
        clickRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(clickRay, out clickPoint))
        {
            Physics.Raycast(clickRay, out posPoint, Mathf.Infinity, mask.value);
            Vector3 mouseMove = posPoint.point;
            d.transform.position = (new Vector3(mouseMove.x, (plane.transform.position.y+5), mouseMove.z));
      
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
            d.transform.position = new Vector3(pos.x, pos.y+5 ,pos.z);
			Defender d1Script = d.GetComponent<Defender> ();
			d1Script.StartFire ();
        }
        else
        {
            Destroy(d);
        }

        GetComponent<CanvasGroup>().blocksRaycasts = true;

    }
}
=======
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Draggable : MonoBehaviour, IBeginDragHandler,IDragHandler,IEndDragHandler{
    public GameObject Defender1;
    public GameObject plane;
	public int cost = 10;

	private GameObject d;
	private MoneySystem moneyManager;

    LayerMask mask = 1 << 8;
    Ray clickRay;
    RaycastHit posPoint;
    RaycastHit clickPoint;
    public Transform parentToReturnTo = null;

	void Start() {
		moneyManager = GameObject.Find ("Money").GetComponent<MoneySystem> ();
	}

    public void OnBeginDrag(PointerEventData eventData)
    {
        parentToReturnTo = this.transform;
        GetComponent<CanvasGroup>().blocksRaycasts = false;
        d = (GameObject) Instantiate(Defender1, transform.position, transform.rotation);
        d.transform.SetParent(parentToReturnTo);
    }

	private Boolean Affordable() {
		return moneyManager.currentMoney >= cost;
	}

	private void Cost() {
		moneyManager.currentMoney -= cost;
	}
   

    public void OnDrag(PointerEventData eventData)
    {
        
        clickRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(clickRay, out clickPoint))
        {
            Physics.Raycast(clickRay, out posPoint, Mathf.Infinity, mask.value);
            Vector3 mouseMove = posPoint.point;
            d.transform.position = (new Vector3(mouseMove.x, (plane.transform.position.y + 5), mouseMove.z));
            Debug.Log("mousemove"+mouseMove);
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
            d.transform.position = new Vector3(pos.x, pos.y + 5,pos.z);
			Cost ();
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
>>>>>>> cb99587b1783b0023186bab311be7a643a732f11
