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
        //TODO: tile의 calCost(direction) 이용
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
            throw new Exception("올바른 위치 상태가 아닙니다.");
        }
    }

    public int getLocationState()
    {
        return locationState;
    }
}
