﻿namespace Week10.Abstract_Factory_Pattern_2;

public class Door
{
    private readonly Room _r1;
    private readonly Room _r2;

    public Door(Room r1, Room r2)
    {
        _r1 = r1;
        _r2 = r2;
    }
}