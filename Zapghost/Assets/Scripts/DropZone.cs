using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DropZone : MonoBehaviour {

<<<<<<< HEAD
    private bool isTriggered=false;

	public void OnTriggerEnter(Collider collider)
    {
        if (isTriggered || collider.tag != "Defender") return;
        
        isTriggered = true;
        
        Transform transform = collider.gameObject.transform.parent;
        GameObject parent = transform.gameObject;//icon
        Draggable t = parent.GetComponent<Draggable>();
=======
	public void OnTriggerEnter(Collider collider)
    {
        Draggable t = collider.gameObject.transform.parent.gameObject.GetComponent<Draggable>();
>>>>>>> cb99587b1783b0023186bab311be7a643a732f11

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
