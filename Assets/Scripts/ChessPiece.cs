using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChessPiece : MonoBehaviour
{
    [Header("Attributes")]
    public GameObject controller;
    public GameObject movePlate;

    private int xPos = -1;
    private int yPos = -1;

    private string player;

    [Header("Black Pieces")]
    public Sprite blackQueen;
    public Sprite blackKnight;
    public Sprite blackBishop;
    public Sprite blackKing;
    public Sprite blackRook;
    public Sprite blackPawn;

    [Header("White Pieces")]
    public Sprite whiteQueen;
    public Sprite whiteKnight;
    public Sprite whiteBishop;
    public Sprite whiteKing;
    public Sprite whiteRook;
    public Sprite whitePawn;

    public void Activate()
	{
        controller = GameObject.FindGameObjectWithTag("GameController");

        setCoordinates();

		switch (gameObject.name)
		{
            case "blackQueen":
                this.GetComponent<SpriteRenderer>().sprite = blackQueen;
                break;
            case "blackKnight":
                this.GetComponent<SpriteRenderer>().sprite = blackKnight;
                break;
            case "blackBishop":
                this.GetComponent<SpriteRenderer>().sprite = blackBishop;
                break;
            case "blackKing":
                this.GetComponent<SpriteRenderer>().sprite = blackKing;
                break;
            case "blackRook":
                this.GetComponent<SpriteRenderer>().sprite = blackRook;
                break;
            case "blackPawn":
                this.GetComponent<SpriteRenderer>().sprite = blackPawn;
                break;
            case "whiteQueen":
                this.GetComponent<SpriteRenderer>().sprite = whiteQueen;
                break;
            case "whiteKnight":
                this.GetComponent<SpriteRenderer>().sprite = whiteKnight;
                break;
            case "whiteBishop":
                this.GetComponent<SpriteRenderer>().sprite = whiteBishop;
                break;
            case "whiteKing":
                this.GetComponent<SpriteRenderer>().sprite = whiteKing;
                break;
            case "whiteRook":
                this.GetComponent<SpriteRenderer>().sprite = whiteRook;
                break;
            case "whitePawn":
                this.GetComponent<SpriteRenderer>().sprite = whitePawn;
                break;
        }
	}

    public void setCoordinates()
	{
        float x = xPos;
        float y = yPos;

        x *= 0.66f;
        y *= 0.66f;

        x += -2.3f;
        y += -2.3f;

        this.transform.position = new Vector3(x, y, -1f);
	}
}
