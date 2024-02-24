using UnityEngine;
using System.Collections;
using Random = UnityEngine.Random;

public class Stats : MonoBehaviour {

    public static float percentage { get; set; }
    public static int stage { get; set; }
    public static float time { get; set; }


    public static int health(int last_h)
    {
        var h = (int)get_upgrade(last_h, percentage);
        return h;
    }

    public static int armor(int last_a)
    {
        var h = (int)get_upgrade(last_a, percentage);
        return h;
    }

    public static int power(int last_p)
    {
        var h = (int)get_upgrade(last_p, percentage);
        return h;
    }


    public static int calculate_damage (bool to_enemy)
    {
        var damage = 0;
        if (to_enemy)
        {
            var def = Enemy.armor + Enemy.health;
            damage = def - Player.power / 2;
        }
        else
        {
            var def = Player.armor + Player.health;
            damage = def - Enemy.power / 2;
        }
        return damage;
    }

    public static float get_percentage(float max, float percentage)
    {
        if (max == 0) return 0;
        return (percentage / (max / 100f));
    }

    public static float get_upgrade(int last_h, float percentage)
    {
        var new_h = 0f;
        var h = last_h / 100f;
        var gs = stage / 100f;
        new_h = gs + last_h + h * (int)percentage;
        if (new_h == 0) return 0;
        return new_h;
    }

}
