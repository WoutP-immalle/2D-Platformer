using UnityEngine;
using System.Collections;

public class BackButton : MonoBehaviour {

    public string mainMenu;

    public void GoBack()
    {
        Application.LoadLevel(mainMenu);
    }
}
