using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class uıcontroller : MonoBehaviour
{
    public DroneController droneController;
    public TextMeshProUGUI tibbi;
    public TextMeshProUGUI yiyecek;

    // Update is called once per frame
    void Update()
    {
        tibbi.text = "Drone üzerindeki tıbbi yardım miktarı: " + droneController.ilacCount;
        yiyecek.text = "Drone üzerindeki yiyecek yardım miktarı: " + droneController.yemekCount;

	}
}
