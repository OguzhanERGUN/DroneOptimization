using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clusters : MonoBehaviour
{
    public List<Node> nodes;
    public Node mean;


    public Clusters(Node node)
    {
		mean = node;
		nodes = new List<Node>();
	}
}
