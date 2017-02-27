using UnityEngine;
using System.Collections;

public class ExitLevel2 : MonoBehaviour
{
    public bool pillTaken = false;
    bool inRange = false;
    Animator animator;
	// Use this for initialization
	void Start ()
    {
        animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        pillTaken = GameObject.FindGameObjectWithTag("Pill Tester 2").GetComponent<PillTester2>().haveTaken;
        if(pillTaken)
        {
            animator.SetBool("PillTaken", true);
        }

        if (inRange && Input.GetButton("Fire1"))
        {
            
        }
	}

    void OnTriggerEnter(Collider other)
    {
        inRange = true;
    }

    IEnumerator closeDoor()
    {
        animator.SetBool("PillTaken", false);
        animator.SetBool("ButtonPressed", true);
        yield return new WaitForSeconds(1);
        animator.enabled = false;
        SteamVR_LoadLevel.Begin("stuff");
    }
}
