using UnityEngine;
using System.Collections;

public class Basic_Movement : MonoBehaviour {

    public AudioClip alertSound;

    bool inRange = false;

    private AudioSource source;
    private float volLowRange = .5f;
    private float volHighRange = 1.0f;

    void Awake()
    {
        source = GetComponent<AudioSource>();
    }

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
	   
	}

 
}
