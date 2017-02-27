using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DropZone : MonoBehaviour {

<<<<<<< HEAD

    private bool isTriggered=false;

    public void OnTriggerEnter(Collider collider)
=======
    private bool isTriggered=false;

	public void OnTriggerEnter(Collider collider)
>>>>>>> 37c61bae60062079ed60c8163507414f99aee12f
    {
        if (isTriggered || collider.tag != "Defender") return;
        
        isTriggered = true;
<<<<<<< HEAD
        //Debug.Log("enter");
        Transform transform = collider.gameObject.transform.parent;
        GameObject parent = transform.gameObject;//icon
        Draggable t = parent.GetComponent<Draggable>();
        //Draggable t = collider.gameObject.transform.parent.gameObject.GetComponent<Draggable>();
=======
        
        Transform transform = collider.gameObject.transform.parent;
        GameObject parent = transform.gameObject;//icon
        Draggable t = parent.GetComponent<Draggable>();
>>>>>>> 37c61bae60062079ed60c8163507414f99aee12f

        if (t != null)
        {
            t.parentToReturnTo = this.transform;
        }


    }

<<<<<<< HEAD
=======

>>>>>>> 37c61bae60062079ed60c8163507414f99aee12f
    void Update()
    {
        isTriggered = false;
    }


}
