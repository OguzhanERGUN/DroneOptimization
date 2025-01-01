using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DroneController : MonoBehaviour
{
	public int yemekCount;
	public int ilacCount;
	private bool startgame = false;
	public KMeans KMeans;
	public float Speed = 5f; // Hareket hýzý
	public Node targetNode;

	public Transform Repo;
	public List<Node> reachedNodes;



	private void OnEnable()
	{
		reachedNodes = new List<Node>();
		yemekCount = 15;
		ilacCount = 15;
	}


	private void Update()
	{


		if (Input.GetKeyDown(KeyCode.Q))
		{
			startgame = true;
		}

		if (startgame)
		{

			foreach (var item in GameManager.gameManager.nodes)
			{
				if (item.yiyecek == 0 && item.tibbi == 0)
				{
					continue;
				}

				else
				{
					if (targetNode == null)
					{
						targetNode = item;
					}

					if (Vector3.Distance(transform.position, targetNode.position) < Vector3.Distance(transform.position, item.position))
					{
						continue;
					}

					else
					{
						targetNode = item;
					}



				}
			}

			MoveTarget(targetNode);

		}

	}

	public void MoveTarget(Node target)
	{

		if (yemekCount >= target.yiyecek && ilacCount >= target.tibbi)
		{
			transform.position = Vector2.MoveTowards(transform.position, target.transform.position, Speed * Time.deltaTime);
			if (Vector2.Distance(transform.position, target.position) < 0.01f)
			{
				reachedNodes.Add(target);
				ilacCount -= target.tibbi;
				yemekCount -= target.yiyecek;
				targetNode.yiyecek = 0;
				targetNode.tibbi = 0;
				targetNode = null;
				Debug.Log("Hedefe ulaþýldý!");
			}
		}

		else
		{
			transform.position = Vector2.MoveTowards(transform.position, Repo.position, Speed * Time.deltaTime);
		}
	}


}
