using UnityEngine;
using System.Collections;

public class WaterZone : MonoBehaviour {

    private PlayerController thePlayer;

    // Use this for initialization
    void Start()
    {
        thePlayer = FindObjectOfType<PlayerController>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "Player")
        {
            thePlayer.inWater = true;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.name == "Player")
        {
            thePlayer.inWater = false;
        }
    }
}
