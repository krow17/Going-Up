using UnityEngine;
using System.Collections;

public class Enter2_Controller : MonoBehaviour {

    Animator animator;

	// Use this for initialization
	void Start ()
    {
        animator = GetComponent<Animator>();
        animator.SetBool("Waiting", true);
	}
	
	// Update is called once per frame
	void Update ()
    {
	
	}

    void OnTriggerEnter(Collider other)
    {
        animator.SetBool("Waiting", false);
        animator.SetBool("Ready", true);
    }
}
