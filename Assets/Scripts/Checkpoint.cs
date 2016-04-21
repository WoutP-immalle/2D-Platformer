using UnityEngine;
using System.Collections;

public class Checkpoint : MonoBehaviour {

    public LevelManager levelManager;

    public Sprite Checkpoint_Flag_Up;
    public Sprite Checkpoint_Flag_Down;

    public AudioSource spawnSoundEffect;


    // Use this for initialization
    void Start()
    {
        levelManager = FindObjectOfType<LevelManager>();
    }

    // Update is called once per frame
    void Update () {
	
	}
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "Player")
        {
            levelManager.currentCheckpoint = gameObject;

            spawnSoundEffect.Play();

            if(this.gameObject.GetComponent<SpriteRenderer>().sprite == Checkpoint_Flag_Down)
            {
                this.gameObject.GetComponent<SpriteRenderer>().sprite = Checkpoint_Flag_Up;
            }

            Debug.Log("Activated Checkpoint " + transform.position);
        }
    }

}
