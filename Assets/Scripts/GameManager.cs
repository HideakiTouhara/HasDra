using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour 
{

	public const int MachingCount = 3;

	enum GameState
	{
		Idle,
		PieceMove,
		DeletePiece,
		FillPiece,
	}

	[SerializeField]
	private Board board;
	[SerializeField]
	private Text stateText;

	private GameState currentState;
	private Piece selectedPiece;

	// Use this for initialization
	void Start () 
	{	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
