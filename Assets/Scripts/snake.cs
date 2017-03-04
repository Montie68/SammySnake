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
    public GameObject BodyPart;
    public PLAYER_DIRECTION direction;
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
    snake()
    {
        GameObject head = null, body = null, tail = null;

        foreach (GameObject obj in BodyParts)
        {
            if (obj.tag == "head")
            {
                head = obj;
            }
            else if (obj.tag == "tail")
            {
                tail = obj;
            }
            else if (obj.tag == "body")
            {
                body = obj;
            }
        }

        Body[0].BodyPart = head;
        Body[1].BodyPart = body;
        Body[3].BodyPart = tail;

        for (int i = 0; i < 3; i++)
        {
            Body[i].direction = PLAYER_DIRECTION.RIGHT;
        }

    }
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
