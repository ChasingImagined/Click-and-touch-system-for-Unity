using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public struct E_OnClickStart : IEvent
{
    public Vector2 firstDot;
}

public struct E_OnClickStay : IEvent
{
    public Vector2 firstDot;
    public Vector2 lastDot;
}

public struct E_OnclickStop : IEvent
{
    public Vector2 firstDot;
    public Vector2 lastDot;
}