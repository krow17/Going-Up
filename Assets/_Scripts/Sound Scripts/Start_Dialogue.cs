using UnityEngine;
using System.Collections;

public class Start_Dialogue : MonoBehaviour {

    public AudioClip alertSound;
    Animator animator;

    private AudioSource source;
    private float volLowRange = .5f;
    private float volHighRange = 1.0f;
    bool inRange = false;


    void Awake()
    {
        source = GetComponent<AudioSource>();
        animator = GetComponent<Animator>();

    }
    // Use this for initialization
    void Start ()
    {
        StartCoroutine(playStartDial());
    }
	
	// Update is called once per frame
	void Update ()
    {
	
	}

    IEnumerator playStartDial()
    {
        float vol = Random.Range(volLowRange, volHighRange);
        source.PlayOneShot(alertSound, vol);
        yield return new WaitForSeconds(source.clip.length);
        source.Pause();
        print("audio finished");
        animator.SetBool("AudioDone", true);
    }

    void OnTriggerEnter(Collider other)
    {
        animator.SetBool("Outside", true);
        animator.SetBool("AudioDone", false);
    }
}
