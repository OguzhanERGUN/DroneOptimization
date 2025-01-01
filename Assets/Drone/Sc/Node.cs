using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node : MonoBehaviour
{
	private SpriteRenderer spriteRenderer;
	public int tibbi;/* týbbi yardým*/
	public int yiyecek;/* yiyecek yardým*/
	public Vector2 position;
	public bool isattended;
	public Dictionary<float,Node> Distances;
	public Node mean;




	private void Start()
	{
		Distances = new Dictionary<float, Node>();
	}


	private void OnEnable()
	{
		tibbi = Random.Range(0, 5);
		yiyecek = Random.Range(0, 5);

		Vector3 vector3 = new Vector3(
			Random.Range(-GameManager.gameManager.xBound, GameManager.gameManager.xBound), 
			Random.Range(-GameManager.gameManager.yBound, GameManager.gameManager.yBound));
		transform.position = vector3;
		spriteRenderer = GetComponent<SpriteRenderer>();

		position = transform.position;
	}


	public void SetColor(Color color)
	{
		spriteRenderer.color = color;
	}

}
