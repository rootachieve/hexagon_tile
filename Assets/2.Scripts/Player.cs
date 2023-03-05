using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Player : MonoBehaviour
{
    public const int STATE_TOP = 1;
    public const int STATE_BOT = -1;

    private int locationState = STATE_BOT;
    private Coordinate location = new Coordinate(0, 0);

    public void setCoordinate(Coordinate coor)
    {
        location = coor;
    }

    public Coordinate getCoordinate()
    {
        return location;
    }


    public bool getDirectionAble(int direction)
    {
        //TODO: tile�� calCost(direction) �̿�
        return false;
    }

    public void changeLocationState(int state)
    {
        if (state == STATE_BOT || state == STATE_TOP)
        {
            locationState = state;
        }
        else
        {
            throw new Exception("�ùٸ� ��ġ ���°� �ƴմϴ�.");
        }
    }

    public int getLocationState()
    {
        return locationState;
    }
}
