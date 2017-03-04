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

public struct SnakeBody
{
    GameObject BodyPart;
    PLAYER_DIRECTION direction;
};

public class snake : MonoBehaviour {

    public GameObject[] BodyParts;

    private enum PLAYER_STATE
    {
        ALIVE,
        DEAD,
        EAT
    };
    private SnakeBody[] Body;
    private SnakeBody[] TempBody;


    private PLAYER_STATE PlayerState;

    // Use this for initialization
    void Start () {
        PlayerState = PLAYER_STATE.ALIVE;

	}
	
	// Update is called once per frame
	void Update () {
		if (PlayerState == PLAYER_STATE.ALIVE)
        {

        }
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
