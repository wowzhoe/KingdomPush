using UnityEngine;
using System.Collections;

public class Manager : MonoBehaviour {

    public enum unit_difficult
    {
        non_elite,
        elite,
        boss,
        emperor,
        godlike,
    }

    public static unit_difficult Unit;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


    public static void calculate_time()
    {
        switch (Unit)
        {
            case unit_difficult.non_elite:
                Stats.time = 30f;
                break;
            case unit_difficult.boss:
                Stats.time = 10f;
                break;
        }
    }
}
