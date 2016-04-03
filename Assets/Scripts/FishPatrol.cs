using UnityEngine;
using System.Collections;

public class FishPatrol : MonoBehaviour {


    public float moveSpeed;
    public bool moveRight;

    public Transform wallCheck;
    public float wallCheckRadius;
    public LayerMask whatIsWall;
    private bool hittingWall;



    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        hittingWall = Physics2D.OverlapCircle(wallCheck.position, wallCheckRadius, whatIsWall);



        if (hittingWall)
        {
            moveRight = !moveRight;
        }

        if (moveRight)
        {
            //vector3 is voor de enemy te veranderen van kijkrichting
            transform.localScale = new Vector3(-1f, 1f, 1f);
            GetComponent<Rigidbody2D>().velocity = new Vector2(moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
        }
        else
        {
            transform.localScale = new Vector3(1f, 1f, 1f);
            // -moveSpeed om te zeggen dat de enemy left moet gaan (niet gelijk aan right)
            GetComponent<Rigidbody2D>().velocity = new Vector2(-moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
        }
    }
}
