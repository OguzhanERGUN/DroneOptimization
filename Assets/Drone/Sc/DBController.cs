using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Linq;

public class DBController : MonoBehaviour
{

	public DroneController droneController;
	string filename = "";
	string filenamedrone = "";
	// Start is called before the first frame update
	void Start()
	{
		filename = Application.dataPath + "/game.csv";
		filenamedrone = Application.dataPath + "/drone.csv";
	}


	private void Update()
	{
		if (Input.GetKeyDown(KeyCode.Space))
		{
			WriteNodesInfos();
		}

		if (Input.GetKeyDown(KeyCode.D))
		{
			WriteDroneInfos();
		}
	}


	public void WriteNodesInfos()
	{
		TextWriter textWriter = new StreamWriter(filename, false);
		textWriter.WriteLine("Konum x, Konum Y, Yemek Ýhtiyacý, Ýlaç Ýhtiyacý, Merkeze olan uzaklýk");
		textWriter.Close();


		textWriter = new StreamWriter(filename, true);

		foreach (Node node in GameManager.gameManager.nodes)
		{
			textWriter.WriteLine(
				FloatToDotString(node.position.x) + "," +
				FloatToDotString(node.position.y) + "," + 
				node.yiyecek + "," + 
				node.tibbi + "," +
				FloatToDotString(node.Distances.Keys.Min()));
		}
		textWriter.Close();



		Debug.Log("Data saved successfuly...");
	}


	public void WriteDroneInfos()
	{
		TextWriter textWriter = new StreamWriter(filenamedrone, false);
		textWriter.WriteLine("Gidilen ihtiyaç noktasý");
		textWriter.Close();


		textWriter = new StreamWriter(filenamedrone, true);

		foreach (Node node in droneController.reachedNodes)
		{
			textWriter.WriteLine(
				node.name);
		}

		textWriter.Close();



		Debug.Log("Data saved successfuly...");
	}

	public static string FloatToDotString(float value)
	{
		return value.ToString().Replace(',', '.');
	}


}
