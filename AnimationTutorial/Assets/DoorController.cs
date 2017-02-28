using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour {
    Animator animator;
	// Use this for initialization
	void Start () {
        animator = GetComponent<Animator>();
    }
	void OnGUI ()
    {
        if (GUILayout.Button("Open Door"))
            animator.SetInteger("DoorClose", 0);
        animator.SetInteger("DoorOpen", 1);

        if (GUILayout.Button("Close Door"))
            animator.SetInteger("DoorOpen", 0);
        animator.SetInteger("DoorClose", 1);


    }
    // Update is called once per frame
    void Update () {
		
	}
}
