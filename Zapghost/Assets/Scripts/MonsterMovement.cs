using UnityEngine;
using System.Collections;

public class MonsterMovement : MonoBehaviour
{
	public float moveSpeed = 5f;
	public int type = 0;
	private Color originColor;
	public float frozenTime;

	void Start() {
		Renderer[] rds = transform.GetComponentsInChildren<Renderer> ();

		foreach (Renderer r in rds) {
			foreach (Material m in r.materials) {
				m.shader = Shader.Find ("Specular");
				originColor = m.GetColor ("_Color");
			}
		}
	}


	void Update ()
	{
		Renderer[] rds = transform.GetComponentsInChildren<Renderer> ();
		if (Time.time < frozenTime) {
			foreach (Renderer r in rds) {
				foreach (Material m in r.materials) {
					m.shader = Shader.Find ("Specular");
					//				Color color = m.GetColor ("_Color");
					//				Color newColor;
					//				float grey = Vector3.Dot(new Vector3(color.r, color.g, color.b), new Vector3(0.299f, 0.587f, 0.114f)); 
					//				newColor = new Color(grey, grey, grey, color.a); 
					//				newColor.r -= 0.15f; 
					//				newColor.b += 0.15f; 
					m.SetColor ("_Color", new Color (0, 83, 246, 255));
				}
			}
			if (type == 0) {
				transform.Translate (new Vector3 (0, 0, -1) * moveSpeed * 0.7f * Time.deltaTime);
			} else {
				transform.Translate (new Vector3 (0, 0, 1) * moveSpeed * 0.7f * Time.deltaTime);
			}

		} else {
			foreach (Renderer r in rds) {
				foreach (Material m in r.materials) {
					m.shader = Shader.Find ("Specular");
					m.SetColor ("_Color", originColor);
				}
			}
			if (type == 0) {
				transform.Translate (new Vector3 (0, 0, -1) * moveSpeed * Time.deltaTime);
			} else {
				transform.Translate (new Vector3 (0, 0, 1) * moveSpeed * Time.deltaTime);
			}

		}
	}
}