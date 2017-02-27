using UnityEngine;
using System.Collections;
using UnityStandardAssets.Characters.FirstPerson;

public class Player_Animation : MonoBehaviour
{
    public bool haseMoved = false;
    public GameObject player;
    public GameObject teleporterA;
    public Camera mainCam;
    //public int moveCounter = 0;
    private float volLowRange = .5f;
    private float volHighRange = 1.0f;

    public float forward;

    RigidbodyFirstPersonController play;

    public Light light1;
    public Light light2;
    public Light light3;
    public Light light4;

    public AudioClip boomSound;
    public AudioClip squeekSound;
    public AudioClip slamSound;
    public AudioClip breathing;

    public AudioSource source;
    Animator animator;

	// Use this for initialization
	void Start ()
    {
        source = GetComponent<AudioSource>();
        animator = GetComponent<Animator>();
        //play = GameObject.FindWithTag("HitReactor").GetComponent<RigidbodyFirstPersonController>();
        

    }
	
	// Update is called once per frame
	void Update ()
    {
        haseMoved = GameObject.FindGameObjectWithTag("To_Impossible").GetComponent<Teleporter_A>().haveUsed;
        if(haseMoved)
        {
            StartCoroutine(Player_Animate());
            animator.SetBool("Ready", false);
            GameObject.FindGameObjectWithTag("To_Impossible").GetComponent<Teleporter_A>().haveUsed = false;
            haseMoved = false;
            
        }

    }


    IEnumerator Player_Animate()
    {

        float vol = Random.Range(volLowRange, volHighRange);
        yield return new WaitForSeconds(6);
        player.transform.position = new Vector3(-39f, 0.42f, player.transform.position.z);
       
        
        light1.enabled = false;
        source.PlayOneShot(boomSound, vol);

        yield return new WaitForSeconds(2);
        player.transform.position = new Vector3(-34.995f, 0.42f, player.transform.position.z); //-5.995
        light2.enabled = false;
        source.PlayOneShot(boomSound, vol);

        yield return new WaitForSeconds(2);
        player.transform.position = new Vector3(-26f, 0.42f, player.transform.position.z); //-7.18
        light3.enabled = false;
        source.PlayOneShot(boomSound, vol);
        yield return new WaitForSeconds(3);
        
        //start creepy door opening animation
        animator.SetBool("Ready", true);
        GetComponent<AudioSource>().clip = squeekSound; 
        source.PlayOneShot(squeekSound, vol);
        yield return new WaitForSeconds (source.clip.length);

        //start door slamming animation
        animator.SetBool("Ready", false);
        GetComponent<AudioSource>().clip = slamSound;
        source.PlayOneShot(slamSound, vol);
        yield return new WaitForSeconds(1);
        Destroy(light4);
        RenderSettings.fogDensity = 1;
         
        //start awful breathing sound
        GetComponent<AudioSource>().clip = breathing;
        GetComponent<AudioSource>().priority = 1;
        source.PlayOneShot(breathing, vol);
        yield return new WaitForSeconds(source.clip.length);

        //return player to normal room. 
        RenderSettings.fogDensity = 0.2f;
        player.transform.position = new Vector3(-36.86f, .42f, 10.5f);
        player.transform.eulerAngles = new Vector3(player.transform.eulerAngles.x, player.transform.eulerAngles.y, player.transform.eulerAngles.z);
        Destroy(teleporterA);


    }
}
