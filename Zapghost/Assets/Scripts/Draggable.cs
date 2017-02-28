using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Draggable : MonoBehaviour, IBeginDragHandler,IDragHandler,IEndDragHandler{
    public GameObject defObj;
    public GameObject plane;
	public int cost = 10;

	private GameObject d;
	private MoneySystem moneyManager;

    LayerMask mask = 1 << 10;
    Ray clickRay;
    RaycastHit posPoint;
    RaycastHit clickPoint;
    public Transform parentToReturnTo = null;

	void Start() {
		moneyManager = GameObject.Find ("Money").GetComponent<MoneySystem> ();
	}

    public void OnBeginDrag(PointerEventData eventData)
    {
		if (Affordable ()) {
			parentToReturnTo = this.transform;
			GetComponent<CanvasGroup> ().blocksRaycasts = false;
			d = (GameObject)Instantiate (defObj, transform.position, transform.rotation);
			d.transform.SetParent (parentToReturnTo);
		} else {
			// give information about cannot get this defender

		}
    }

	private Boolean Affordable() {
		return moneyManager.currentMoney >= cost;
	}

	private void Cost() {
		if (moneyManager.currentMoney < cost) {
			//give the exception message to users
		}
		moneyManager.currentMoney -= cost;
	}
   

    public void OnDrag(PointerEventData eventData)
    {
		if (d == null)
			return;
	
        clickRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(clickRay, out clickPoint))
        {
            Physics.Raycast(clickRay, out posPoint, Mathf.Infinity, mask.value);
            Vector3 mouseMove = posPoint.point;
			d.transform.position = (new Vector3(mouseMove.x,mouseMove.y,(plane.transform.position.z)));
        }
        else
        {
            d.transform.position = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y,360));
        }

    }

    public void OnEndDrag(PointerEventData eventData)
    {
		if (d == null)
			return;
        
        if (Physics.Raycast(clickRay, out clickPoint) && parentToReturnTo.childCount == 0)
        {
            
            d.transform.SetParent(parentToReturnTo);
            Vector3 pos = parentToReturnTo.transform.position;
            d.transform.position = new Vector3(pos.x, pos.y ,pos.z - 0.04f);
			Cost ();
			Defender defClass = d.GetComponent<Defender> ();
			defClass.StartFire ();
			defClass.Place ();
        }
        else
        {
            Destroy(d);
        }

        GetComponent<CanvasGroup>().blocksRaycasts = true;

    }
}