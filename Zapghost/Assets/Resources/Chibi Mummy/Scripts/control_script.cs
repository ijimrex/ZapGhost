using UnityEngine;
using System.Collections;

public class control_script : MonoBehaviour {

	Animator anim;
	bool boolper;


	void Update ()
	{
		anim = GetComponentInChildren<Animator>();
		Run();
	}



	public void Run ()
	{
		boolper = anim.GetBool("isRun");
		anim.SetBool ("isRun", !boolper);
	}
}
