using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public int weaponPlayer = 1;
    public int phase;
    public bool Helper = true;
    public int lives;


    private static GameManager instance = null;

    public static GameManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<GameManager>();

                if (instance == null)
                {
                    GameObject go = new GameObject();
                    go.name = "GameManager";
                    instance = go.AddComponent<GameManager>();
                    DontDestroyOnLoad(go);
                }
            }
            return instance;
        }
    }

    public void beginGame()
    {
        lives = 3;
    }

    public void setPhase(int phase)
    {
        this.phase = phase;
    }

    public void phaseChange()
    {
        if (phase < 5) //fase 5 seria o ultimo chefão
        {
            phase++;
        }
        else
        {
            phase = 1;
        }
    }

    public int getPhase()
    {
        return phase;
    }

    public bool getHelper()
    {
        return Helper;
    }

    public void characterExchange()
    {
        Helper = !Helper;
    }

    void Awake()
    {

        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void weaponExchange()
    {
        if(weaponPlayer < phase)
        {
            weaponPlayer++;
        } else
        {
            weaponPlayer = 1;
        }
    }

    public int getWeapon()
    {
        return weaponPlayer;
    }

}
