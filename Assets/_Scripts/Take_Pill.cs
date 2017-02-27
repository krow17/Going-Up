using UnityEngine;
using System.Collections;

public class Take_Pill : MonoBehaviour {

    public GameObject pill;
    public Canvas textCanvas;

    bool inRange = false;

	// Use this for initialization
	void Start ()
    {
        textCanvas.enabled = false;
    }
	
	// Update is called once per frame
	void Update ()
    {
	    if(inRange)
        {
            textCanvas.enabled = true;
            if (inRange && Input.GetButton("Fire1"))
            {
                Destroy(pill);
                inRange = false;
                
            }
        }
        textCanvas.enabled = false;
        Destroy(this);
    }

    void OnTriggerEnter(Collider other)
    {
        inRange = true;
    }
}
