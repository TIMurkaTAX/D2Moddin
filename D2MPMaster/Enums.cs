﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace d2mpserver
{
    [Serializable]
    public enum ServerRegion : int
    {
        UNKNOWN=0,
        NA=1,
        EU=2,
        AUS=3,
        CN=4
    }

    [Serializable]
    public enum GameState : int
    {
        Init=0,
        WaitLoad=1,
        HeroSelect=2,
        StratTime=3,
        PreGame=4,
        Playing=5,
        PostGame=6,
        Disconnect=7
    }

    public enum GameEvents : int
    {
        GameStateChange=0,
        PlayerConnect=1,
        PlayerDisconnect=2,
        PlayerTeam=3,
        HeroDeath=4,
        TowerKill=5,
        CourierKill=6,
        RoshanKill=7,
        RuneBottled=8,
        RuneUsed=9,
        AegisPickup=10,
        AegisSteal=11,
        BuyBack=12,
        AegisDeny=13,
        FirstBlood=14,
        TowerDeny=15,
        ItemPurchase=16,
        CallGG=17,
        CancelGG=18
    }
}