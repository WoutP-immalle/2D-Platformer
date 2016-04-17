using UnityEngine;
using System.Collections;

public class LevelSelectTouch : MonoBehaviour {

    public LevelSelectManager theLevelSelectMananger;

	// Use this for initialization
	void Start () {
        theLevelSelectMananger = FindObjectOfType<LevelSelectManager>();

        theLevelSelectMananger.touchMode = true;
	}
	
    public void MoveLeft()
    {
        theLevelSelectMananger.positionSelector -= 1;

        if (theLevelSelectMananger.positionSelector < 0)
        {
            theLevelSelectMananger.positionSelector = 0;
        }
    }

    public void MoveRight()
    {
        theLevelSelectMananger.positionSelector += 1;

        if (theLevelSelectMananger.positionSelector >= theLevelSelectMananger.levelTags.Length)
        {
            theLevelSelectMananger.positionSelector = theLevelSelectMananger.levelTags.Length - 1;
        }
    }

    public void LoadLevel()
    {
        PlayerPrefs.SetInt("PlayerLevelSelectPosition", theLevelSelectMananger.positionSelector);
        Application.LoadLevel(theLevelSelectMananger.levelName[theLevelSelectMananger.positionSelector]);
    }
}
