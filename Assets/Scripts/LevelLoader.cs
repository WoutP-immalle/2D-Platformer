using UnityEngine;
using System.Collections;


public class LevelLoader : MonoBehaviour {

    public bool playerInZone;

    public string levelToLoad;

    public string levelTag;

	// Use this for initialization
	void Start () {
        playerInZone = false;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetAxisRaw("Vertical") > 0 && playerInZone)
        {
            LoadLevel();
        } 
	}

    public void LoadLevel()
    {
        // 1 is unlocked, 0 is locked
        PlayerPrefs.SetInt(levelTag, 1);
        //gebruik Application.LoadLevelAsync(levelToLoad); om een laad scherm te maken
        Application.LoadLevel(levelToLoad);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.name == "Player")
        {
            playerInZone = true;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.name == "Player")
        {
            playerInZone = false;
        }
    }
}
