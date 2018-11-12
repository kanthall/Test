﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour {

    [SerializeField] float screenWidthInUnits = 16f;
    [SerializeField] float minX = 1f;
    [SerializeField] float maxX = 15;

    Ball theBall;
    GameSession theGameSession;

    void Start () {
    //Set Cursor to not be visible
         Cursor.visible = false;
        theGameSession = FindObjectOfType<GameSession>();
        theBall = FindObjectOfType<Ball>();
    }
	
	// Update is called once per frame
	void Update () {
        float mousePositionInUnits = Input.mousePosition.x / Screen.width * screenWidthInUnits;
    //paddle moving
        Vector2 paddlePosition = new Vector2(transform.position.x, transform.position.y);
    //limit of paddle position
        paddlePosition.x = Mathf.Clamp(mousePositionInUnits, minX, maxX);
        transform.position = paddlePosition;
	}


    // autoplay for the paddle - math clamp should have this function called to work
    private float GetXPos()
    {
        if (theGameSession.IsAutoPlayEnabled())
        {
            return theBall.transform.position.x;
        }
        else
        {
            return Input.mousePosition.x / Screen.width * screenWidthInUnits;
        }
    }
}
