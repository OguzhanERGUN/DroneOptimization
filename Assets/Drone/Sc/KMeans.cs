using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class KMeans : MonoBehaviour
{
	public int numberOfClusters = 3; // Kümelerin sayýsý
	public List<Node> nodes;
	private List<Node> means;
	private List<Color> colors;
	public List<Clusters> clusters;


	void Start()
	{
		clusters = new List<Clusters>();
		means = new List<Node>();
		nodes = GameManager.gameManager.nodes;
		colors = new List<Color>();


		if (nodes == null || nodes.Count == 0)
		{
			Debug.LogError("Node listesi boþ! Lütfen önce noktalarý oluþturun.");
			return;
		}

		KMeansClustering();
		VisualizeClusters();
	}



	void KMeansClustering()
	{


		for (int i = 0; i < numberOfClusters; i++)
		{
			int temp = Random.Range(0, nodes.Count);
			means.Add(nodes[temp]);

			clusters.Add(new Clusters(nodes[temp]));
		}




		foreach (Node node in nodes)
		{
			Node closestmean = null;
			for (int i = 0; i < numberOfClusters; i++)
			{
				node.Distances.Add(OklidDistance(node, means[i]), means[i]);
			}
			closestmean = node.Distances[node.Distances.Keys.Min()];
			node.mean = closestmean;

			foreach (var item in clusters)
			{
				if (item.mean != closestmean)
				{
					continue;
				}
				else
				{
					item.nodes.Add(node);
				}
			}

		}




	}

	void VisualizeClusters()
	{
		for (int i = 0; i < numberOfClusters; i++)
		{
			colors.Add(Random.ColorHSV());
		}

		int counter = 0;
		foreach (var item in clusters)
		{
			foreach (var node in item.nodes)
			{
				node.SetColor(colors[counter]);
			}
			counter++;
		}
	}


	private float OklidDistance(Node node1, Node node2)
	{
		float a = Mathf.Abs(Mathf.Sqrt(Mathf.Pow((node1.position.x - node2.position.x), 2) + Mathf.Pow((node1.position.y - node2.position.y), 2)));
		return a;
	}
}
