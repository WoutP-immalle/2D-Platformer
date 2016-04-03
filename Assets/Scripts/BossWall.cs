using UnityEngine;
using System.Collections;

public class BossWall : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        if (FindObjectOfType<BossHealthManager>())
        {
            return;
        }

        Destroy(gameObject);
	}
}
