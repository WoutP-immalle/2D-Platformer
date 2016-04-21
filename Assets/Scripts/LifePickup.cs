using UnityEngine;
using System.Collections;

public class LifePickup : MonoBehaviour {

    private LifeManager lifeSystem;
    public AudioSource pickupSoundEffect;

    // Use this for initialization
    void Start () {
        lifeSystem = FindObjectOfType<LifeManager>();
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.name == "Player")
        {
            lifeSystem.GiveLife();
            Destroy(gameObject);
        }

        pickupSoundEffect.Play();
    }
}
