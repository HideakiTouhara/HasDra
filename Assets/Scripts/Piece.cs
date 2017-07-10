using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Piece : MonoBehaviour 
{

	//public
	public bool deleteFlag;

	//private
	private Image thisImage;
	private RectTransform thisRectTransform;
	private PieceKind kind;

	void Awake()
	{
		thisImage = GetComponent<Image>();
		thisRectTransform = GetComponent<RectTransform>();

		deleteFlag = false;
	}

	public void SetKind(PieceKind pieceKind)
	{
		kind = pieceKind;
		SetColor();
	}

	public PieceKind GetKind()
	{
		return kind;
	}

	public void SetSize(int size)
	{
		this.thisRectTransform.sizeDelta = Vector2.one * size;
	}

	private void SetColor()
	{
		switch(kind)
		{
			case PieceKind.Red:
				thisImage.color = Color.red;
				break;
			case PieceKind.Blue:
                thisImage.color = Color.blue;
                break;
            case PieceKind.Green:
                thisImage.color = Color.green;
                break;
            case PieceKind.Yellow:
                thisImage.color = Color.yellow;
                break;
            case PieceKind.Black:
                thisImage.color = Color.black;
                break;
            case PieceKind.Magenta:
                thisImage.color = Color.magenta;
                break;
            default:
                break;
		}
	}
}
