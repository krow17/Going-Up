using UnityEngine;
using System.Collections;

public class Background_Audio : MonoBehaviour
{

    public AudioClip alertSound;

    private AudioSource source;
    private float volLowRange = .7f;
    private float volHighRange = 1.2f;

    // Use this for initialization
    void Start ()
    {
        float vol = Random.Range(volLowRange, volHighRange);
        source.loop = true;
        source.clip = alertSound;
        source.Play();
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
