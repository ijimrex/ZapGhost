using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DropZone : MonoBehaviour {

	private bool isTriggered=false;
	private Renderer rd;
	private Color tmp;

	void Start() {
		rd = GetComponent<MeshRenderer> ();
	}

	void OnTriggerEnter(Collider collider)

    {
		if (isTriggered || collider.tag != "Defender") return;

		tmp = rd.material.color;

		rd.material.color = Color.red;

		isTriggered = true;

        Draggable t = collider.gameObject.transform.parent.gameObject.GetComponent<Draggable>();

        if (t != null)
        {
            t.parentToReturnTo = this.transform;
        }
    }

	void OnTriggerExit(Collider other) {
		if (other.tag == "Defender") {
			rd.material.color = tmp;
		}
	}

	void Update()
	{
		isTriggered = false;
		if (transform.childCount == 1) {
			rd.material.color = tmp;
		}
	}
}
