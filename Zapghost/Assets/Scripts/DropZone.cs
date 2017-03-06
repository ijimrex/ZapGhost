using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DropZone : MonoBehaviour {

	private bool isTriggered=false;
	private Renderer rd;

	void Start() {
		rd = GetComponent<MeshRenderer> ();
	}

	void OnTriggerEnter(Collider collider)

    {
		if (isTriggered || collider.tag != "Defender") return;

		rd.enabled = true;

		isTriggered = true;

        Draggable t = collider.gameObject.transform.parent.gameObject.GetComponent<Draggable>();

        if (t != null)
        {
            t.parentToReturnTo = this.transform;
        }
    }

	void OnTriggerExit(Collider other) {
		// Destroy everything that leaves the trigger
		if (other.tag == "Defender") {
			rd.enabled = false;
		}
	}

	void Update()
	{
		isTriggered = false;
	}
}
