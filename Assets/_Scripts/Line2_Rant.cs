using UnityEngine;
using System.Collections;

public class Line2_Rant : MonoBehaviour {

    public AudioClip line1;
    public AudioClip line2;
    public bool inRange = false;
    public bool haveUsed = false;

    public AudioSource source;

	// Use this for initialization
	void Start ()
    {
        
	}
	
	// Update is called once per frame
	void Update ()
    {
        
	}

    void OnTriggerEnter(Collider other)
    {
        if(!haveUsed)
            StartCoroutine(line1Rant());
    }

    IEnumerator line1Rant()
    {
        haveUsed = true;
        GetComponent<AudioSource>().clip = line1;
        GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(GetComponent<AudioSource>().clip.length);
        GetComponent<AudioSource>().clip = line2;
        GetComponent<AudioSource>().Play();

        inRange = false;
    }
}
