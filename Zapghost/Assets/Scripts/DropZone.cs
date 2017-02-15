using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DropZone : MonoBehaviour,IDropHandler {

	public void  OnDrop(PointerEventData evenData)
    {
        Draggable t = evenData.pointerDrag.GetComponent<Draggable>();
        if (t != null)
        {
            t.parentToReturnTo = this.transform;
        }
    }
}
