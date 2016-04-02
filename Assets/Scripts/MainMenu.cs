using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {

    public string startLevel;

    public string levelSelect;

    public string level1Tag;

    public string infoMenu;

    public void NewGame()
    {
        PlayerPrefs.SetInt(level1Tag, 1);

        PlayerPrefs.SetInt("PlayerLevelSelectPosition", 0);
        Application.LoadLevel(startLevel);
    }

    public void LevelSelect()
    {
        PlayerPrefs.SetInt(level1Tag, 1);

        if (!PlayerPrefs.HasKey("PlayerLevelSelectPosition"))
        {
            PlayerPrefs.SetInt("PlayerLevelSelectPosition", 0);
        }

        Application.LoadLevel(levelSelect);
    }

    public void QuitGame()
    {
        Debug.Log("Game Exited");
        Application.Quit();
    }

    public void Info()
    {
        Application.LoadLevel(infoMenu);
    }
}
