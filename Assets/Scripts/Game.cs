using UnityEngine;
using System.Collections;
using Random = UnityEngine.Random;
using UnityEngine.UI;

public class Game : MonoBehaviour {

    public GameObject enemy;
    GameObject active_enemy;

    Image enemy_hp; // red
    Image enemy_timer; // blue
    

	// Use this for initialization
	void Start ()
	{
		set_stage();
	}
	
	// Update is called once per frame
	void Update () {
	

	}


    void init_game ()
    {

    }

    void check_stage ()
    {
        var st = Stats.stage % 10;

        if (st == 1)
            Manager.Unit = Manager.unit_difficult.boss;
        else
            Manager.Unit = Manager.unit_difficult.non_elite;
    }

	#region Input
	void input_listener()
	{
		if (Input.GetMouseButtonDown(0))
		{
			
		}
	}


	#endregion

	#region Setters
	void set_stage()
    {
        Stats.stage++;
        set_enemy();
    }

    void set_player()
    {
        Stats.percentage = Random.Range(0, 100);

        Player.health = Stats.health(Player.health + Random.Range(1, Player.health));
        Player.armor = Stats.armor(Player.armor + Random.Range(1, Player.armor));
        Player.power = Stats.power(Player.power + Random.Range(1, Player.power));
    }

    void set_enemy()
    {
        Stats.percentage = Random.Range(0, 100);

        Enemy.health = Stats.health(Enemy.health + Random.Range(1, Enemy.health));
        Enemy.armor = Stats.armor(Enemy.armor + Random.Range(1, Enemy.armor));
        Enemy.power = Stats.power(Enemy.power + Random.Range(1, Enemy.power));

        active_enemy = Instantiate(enemy);
        active_enemy.transform.position = new Vector3(0, -1, 1);

    }
    #endregion


}
