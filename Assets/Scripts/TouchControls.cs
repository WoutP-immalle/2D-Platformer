using UnityEngine;
using System.Collections;

public class TouchControls : MonoBehaviour
{

    private PlayerController thePlayer;

    private LevelLoader levelExit;

    private PauseMenu thePauseMenu;


    // Use this for initialization
    void Start()
    {
        thePlayer = FindObjectOfType<PlayerController>();

        levelExit = FindObjectOfType<LevelLoader>();

        thePauseMenu = FindObjectOfType<PauseMenu>();
    }

    public void LeftArrow()
    {
        thePlayer.Move(-1);
    }

    public void RightArrow()
    {
        thePlayer.Move(1);
    }

    public void UnpressedArrow()
    {
        thePlayer.Move(0);
    }

    public void Sword()
    {
        thePlayer.Sword();
    }

    public void ResetSword()
    {
        thePlayer.ResetSword();
    }

    public void Star()
    {
        thePlayer.FireStar();
    }

    public void Jump()
    {
        thePlayer.Jump();

        if (levelExit.playerInZone)
        {
            levelExit.LoadLevel();
        }
    }

    public void Pause()
    {
        thePauseMenu.PauseUnpause();
    }
}