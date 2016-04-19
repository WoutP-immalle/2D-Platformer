using UnityEngine;
using System.Collections;

public class CoinPickup : MonoBehaviour {

    public int pointsToAdd;

    public AudioSource coinSoundEffect;

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.GetComponent<PlayerController>() == null)
        {
            return;
        }

        ScoreManager.AddPoints(pointsToAdd);

        coinSoundEffect.Play();

        Destroy(gameObject);
    }
}
