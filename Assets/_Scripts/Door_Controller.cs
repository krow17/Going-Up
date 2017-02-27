using UnityEngine;
using System.Collections;

public class Door_Controller : MonoBehaviour {

    Animator animator;

	// Use this for initialization
	void Start ()
    {
        animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update ()
    {
	
	}

    void OnTriggerEnter(Collider collider)
    {
        StartCoroutine(openDoors());
    }

    IEnumerator openDoors()
    {
        animator.SetBool("Close", false);
        animator.SetTrigger("Open");
        yield return new WaitForSeconds(5);
        animator.ResetTrigger("Open");
        animator.SetBool("Close", true);
    }
}
