using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthSystem : MonoBehaviour
{
    [Header("UI Components")]
    [SerializeField]
    private Slider hpSlider;

    [Header("Health Logic")]
    private int tick = 0;
    [SerializeField]
    private int regeneration = 1;
    [SerializeField]
    private int maxHp = 1000;
    private int hp;

    public int Health
    {
        get { return hp; }
        set {
            hpSlider.value = value;
            hp = (value >= 0 ? (value > maxHp ? maxHp : value) : 0);
            if (hp == 0)
            {
                // Game Over
            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        hpSlider.maxValue = maxHp;
        Health = maxHp;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            Health -= 100;
        }
    }

    private void FixedUpdate()
    {
        tick++;
        // Execute every 2nd loop
        if (tick % 2 == 0)
        {
            Health++;
        }
        // Reset tick
        tick = (tick >= 1000 ? 0 : tick);
    }
}