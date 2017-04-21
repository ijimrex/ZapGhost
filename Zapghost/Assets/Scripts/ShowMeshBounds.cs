using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowMeshBounds : MonoBehaviour {

	public Color color = Color.black;

	private Vector3 v3FrontTopLeft;
	private Vector3 v3FrontTopRight;
	private Vector3 v3FrontBottomLeft;
	private Vector3 v3FrontBottomRight;

	// Use this for initialization
	void Start () {
		CalPositions ();
		DrawBox ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void CalPositions() {
		Bounds bounds = GetComponent<MeshFilter> ().mesh.bounds;

		Vector3 v3Center = bounds.center;
		Vector3 v3Extents = bounds.extents;

		v3FrontTopLeft = new Vector3 (v3Center.x - v3Extents.x, v3Center.y - v3Extents.y, v3Center.z + v3Extents.z);
		v3FrontTopRight = new Vector3 (v3Center.x + v3Extents.x, v3Center.y - v3Extents.y, v3Center.z + v3Extents.z);
		v3FrontBottomLeft = new Vector3 (v3Center.x - v3Extents.x, v3Center.y - v3Extents.y, v3Center.z - v3Extents.z);
		v3FrontBottomRight = new Vector3 (v3Center.x + v3Extents.x, v3Center.y - v3Extents.y, v3Center.z - v3Extents.z);

		v3FrontTopLeft = transform.TransformPoint (v3FrontTopLeft);
		v3FrontTopRight = transform.TransformPoint (v3FrontTopRight);
		v3FrontBottomLeft = transform.TransformPoint (v3FrontBottomLeft);
		v3FrontBottomRight = transform.TransformPoint (v3FrontBottomRight);
	}

	void DrawBox() {
		int segements = 10;
		float dis = (v3FrontTopRight.x - v3FrontTopLeft.x) / segements;

		Debug.DrawLine (v3FrontTopLeft, v3FrontTopRight, color);
		Debug.DrawLine (v3FrontTopLeft, v3FrontBottomLeft, color);
		Debug.DrawLine (v3FrontTopRight, v3FrontBottomRight, color);
		Debug.DrawLine (v3FrontBottomLeft, v3FrontBottomRight, color);
		/*
		//draw top
		for (int i = 0; i < segements; i+=2) {
			Debug.DrawLine (new Vector3 (v3FrontTopLeft.x + i * dis, v3FrontTopLeft.y, v3FrontTopLeft.z), new Vector3 (v3FrontTopLeft.x + (i+1) * dis, v3FrontTopLeft.y, v3FrontTopLeft.z), color);
		}
		//draw left
		for (int i = 0; i < segements; i+=2) {
			Debug.DrawLine (new Vector3 (v3FrontTopLeft.x, v3FrontTopLeft.y, v3FrontTopLeft.z + i * dis), new Vector3 (v3FrontTopLeft.x, v3FrontTopLeft.y, v3FrontTopLeft.z + (i+1) * dis), color);
		}
		//draw right
		for (int i = 0; i < segements; i+=2) {
			Debug.DrawLine (new Vector3 (v3FrontTopRight.x, v3FrontTopRight.y, v3FrontTopRight.z + i * dis), new Vector3 (v3FrontTopRight.x, v3FrontTopRight.y, v3FrontTopRight.z + (i+1) * dis), color);
		}
		//draw bottom
		for (int i = 0; i < segements; i+=2) {
			Debug.DrawLine (new Vector3 (v3FrontBottomLeft.x + i * dis, v3FrontBottomLeft.y, v3FrontBottomLeft.z), new Vector3 (v3FrontBottomLeft.x + (i+1) * dis, v3FrontBottomLeft.y, v3FrontBottomLeft.z), color);
		}*/
	}
}
