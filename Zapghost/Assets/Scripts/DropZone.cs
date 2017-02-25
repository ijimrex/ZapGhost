using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DropZone : MonoBehaviour {

	public void OnTriggerEnter(Collider collider)
    {
        Draggable t = collider.gameObject.transform.parent.gameObject.GetComponent<Draggable>();

        if (t != null)
        {
            t.parentToReturnTo = this.transform;
        }
    }
}
