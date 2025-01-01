using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
	[SerializeField] private GameObject nodeObject;
	public List<Node> nodes;
	public static GameManager gameManager;
	public int droneCount;
	public int nodeCount;
	public float xBound;
	public float yBound;
	

	private void Awake()
	{
		gameManager = this;
		nodeCount = Random.Range(40, 51);
		nodes = new List<Node>();

		for (int i = 0; i < nodeCount; i++)
		{
			GameObject obj = Instantiate(nodeObject, Vector3.zero, Quaternion.identity);
			obj.name = "Destek Noktasi " + i;
			nodes.Add(obj.GetComponent<Node>()); ; 
		}
	}

}