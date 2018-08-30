using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {


    Collider2D ballCollider;


	// Use this for initialization
	void Start () {

        ballCollider = ballCollider.GetComponentInChildren<Collider2D>();


	}

    public bool Crash(GameObject ball)
    {

        LayerMask mask = LayerMask.GetMask("Ball");
        RaycastHit2D hit = Physics2D.Raycast(ball.transform.position, Vector2.down, Mathf.Infinity, mask);
        if (hit.collider != null)
        {
            Debug.Log("Not Crash");
            return false;

        }
        else
        {
            //LoseOneLife();
            return true;
        }
    }

    // Update is called once per frame
    void Update () {
		
	}
}
