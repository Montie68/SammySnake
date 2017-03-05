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
    public void SetBody(GameObject bp, PLAYER_DIRECTION dir)
    {
        BodyPart = bp;
        Direction = dir;
    }
    public GameObject BodyPart;
    public PLAYER_DIRECTION Direction;
};

public class snake : MonoBehaviour {

    public GameObject[] BodyParts;
    public SnakeBody[] BodyStart = new SnakeBody[3];

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
    void Awake()
    {
        GameObject[] body = new GameObject[3];

        foreach (GameObject obj in BodyParts)
        {
            if (obj.tag == "head")
            {
                body[0] = obj;
            }
            else if (obj.tag == "tail")
            {
                body[2] = obj;
            }
            else if (obj.tag == "body")
            {
                body[1] = obj;
            }
        }

       for (int i = 0; i < BodyStart.Length; i++)
        {
            BodyStart[i].SetBody(body[i], PLAYER_DIRECTION.RIGHT);
        }
      Body   = BodyStart;

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
        if (PlayerState == PLAYER_STATE.DEAD) return true;
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
