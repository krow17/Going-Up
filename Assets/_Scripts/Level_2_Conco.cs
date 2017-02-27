using UnityEngine;
using System.Collections;

public class Level_2_Conco : MonoBehaviour {

    public AudioClip voice1Line1;
    public AudioClip voice2line1;
    public AudioClip voice1line2;

    private AudioSource source;
    private float volLowRange = .5f;
    private float volHighRange = 1.0f;

    // Use this for initialization
    void Start ()
    {
        StartCoroutine(startDialouge());
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    IEnumerator startDialouge()
    {
        //havePlayed = true;
        GetComponent<AudioSource>().clip = voice1Line1;
        float vol = Random.Range(volLowRange, volHighRange);
        GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(GetComponent<AudioSource>().clip.length + 1);

        GetComponent<AudioSource>().clip = voice2line1;
        GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(GetComponent<AudioSource>().clip.length + 1);

        GetComponent<AudioSource>().clip = voice1line2;
        GetComponent<AudioSource>().Play();

        //inRange = false;

    }
}
