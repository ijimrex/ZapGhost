﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DropZone : MonoBehaviour {


    private bool isTriggered=false;

    public void OnTriggerEnter(Collider collider)
    {
        if (isTriggered || collider.tag != "Defender") return;
        
        isTriggered = true;
        //Debug.Log("enter");
        Transform transform = collider.gameObject.transform.parent;
        GameObject parent = transform.gameObject;//icon
        Draggable t = parent.GetComponent<Draggable>();
        //Draggable t = collider.gameObject.transform.parent.gameObject.GetComponent<Draggable>();

        if (t != null)
        {
            t.parentToReturnTo = this.transform;
        }
    }

    void Update()
    {
        isTriggered = false;
    }


}
