using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum PLAYER_DIRECTION
{
    UP,
    LEFT,
    RIGHT,
    DOWN
};

public class snake : MonoBehaviour {

    public GameObject[] BodyParts;

    private enum PLAYER_STATE
    {
        ALIVE,
        DEAD,
        EAT
    };

    

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    bool PlayerSetDiretion(PLAYER_DIRECTION direction)
    {
        return false;
    }
    bool IsDead()
    {
        return false;
    }

    bool IsEating()
    {
        return false;
    }

    void HasEaten()
    {

    }

}
