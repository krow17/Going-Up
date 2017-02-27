using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class Elevator_Button : MonoBehaviour {

    bool inRange = false;
    Animator animator;
    public GameObject mainCamera;

	// Use this for initialization
	void Start ()
    {
        animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update ()
    {
	    if(inRange && Input.GetButton("Fire1"))
        {
            StartCoroutine(exitLevelOne());
            StopCoroutine(exitLevelOne());
        }
	}

    void OnTriggerEnter(Collider other)
    {
        print("in range of button. Press Q");
        inRange = true;
    }

    IEnumerator exitLevelOne()
    {
        animator.SetBool("ButtonPressed", true);
        animator.SetBool("PillTaken", false);
        yield return new WaitForSeconds(0);
        //SceneManager.LoadScene("_Scenes/Level_2");
        SteamVR_LoadLevel.Begin("_Scenes/Level_2");
    }
}
