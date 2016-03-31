using UnityEngine;
using System.Collections;

public class LevelSelectManager : MonoBehaviour {

    public string[] levelTags;

    public GameObject[] locks;
    public bool[] levelUnlocked;

    public int positionSelector;
    public float distanceBelowLock;

    public string[] levelName;

    public float moveSpeed;

    private bool isPressed;

    

    // Use this for initialization
    void Start () {
	    
        for(int i = 0; i < levelTags.Length; i++)
        {
            if(PlayerPrefs.GetInt(levelTags[i]) == null)
            {
                levelUnlocked[i] = false;
            } else if(PlayerPrefs.GetInt(levelTags[i]) == 0)
            {
                levelUnlocked[i] = false;
            } else
            {
                levelUnlocked[i] = true;
            }

            if (levelUnlocked[i])
            {
                locks[i].SetActive(false);
            }
        }
        positionSelector = PlayerPrefs.GetInt("PlayerLevelSelectPosition");

        transform.position = locks[positionSelector].transform.position + new Vector3(0, distanceBelowLock, 0);
	}
	
	// Update is called once per frame
	void Update () {

        if (!isPressed)
        {
            if(Input.GetAxis("Horizontal") > 0.25f)
            {
                positionSelector += 1;
                isPressed = true;
            }

            if (Input.GetAxis("Horizontal") < -0.25f)
            {
                positionSelector -= 1;
                isPressed = true;
            }

            if(positionSelector >= levelTags.Length)
            {
                positionSelector = levelTags.Length - 1;
            }

            if(positionSelector < 0)
            {
                positionSelector = 0;
            }
        }

        if (isPressed)
        {
            if(Input.GetAxis("Horizontal") < 0.25f && Input.GetAxis("Horizontal") > -0.25f)
            {
                isPressed = false;
            }
        }

        transform.position = Vector3.MoveTowards(transform.position, locks[positionSelector].transform.position + new Vector3(0, distanceBelowLock, 0), moveSpeed * Time.deltaTime);

        if(Input.GetButtonDown("Fire1") || Input.GetButtonDown("Jump"))
        {
            if (levelUnlocked[positionSelector])
            {
                PlayerPrefs.SetInt("PlayerLevelSelectPosition", positionSelector);
                Application.LoadLevel(levelName[positionSelector]);
            }
        }
	}
}
