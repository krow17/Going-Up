using UnityEngine;
using System.Collections;

public class Level_1_Convo : MonoBehaviour {

    public AudioClip voice1Line1;
    public AudioClip voice2line1;
    public AudioClip voice1line2;


    bool inRange = false;
    public bool havePlayed = false;

    private AudioSource source;
    private float volLowRange = .5f;
    private float volHighRange = 1.0f;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
	    
	}

    void OnTriggerEnter(Collider other)
    {
        StartCoroutine(startDialouge());
    }

    IEnumerator startDialouge()
    {
        havePlayed = true;
        GetComponent<AudioSource>().clip = voice1Line1;
        float vol = Random.Range(volLowRange, volHighRange);
        GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(GetComponent<AudioSource>().clip.length + 1);

        GetComponent<AudioSource>().clip = voice2line1;
        GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(GetComponent<AudioSource>().clip.length + 1);

        GetComponent<AudioSource>().clip = voice1line2;
        GetComponent<AudioSource>().Play();

        inRange = false;
        
    }
}
