using UnityEngine;
using System.Collections;

public class ElevatorUse : MonoBehaviour {

    public bool pillTaken;
    bool convoDone = false;
    Animator animator;

	// Use this for initialization
	void Start ()
    {
        animator = GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update () {
        pillTaken = GameObject.FindGameObjectWithTag("PillTester").GetComponent<Conditional_Teleporter>().canUseElevator;
        convoDone = GameObject.FindGameObjectWithTag("Level_1_Convo").GetComponent<Level_1_Convo>().havePlayed;
        if (pillTaken)
        {
            print("Pill Taken");
        }

        if(convoDone)
        {
            StartCoroutine(goingUp());
        }
    }

    IEnumerator goingUp()
    {
        animator.SetBool("PillTaken", true);
        yield return new WaitForSeconds(3);
        animator.SetBool("PillTaken", false);
    }
}
