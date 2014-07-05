﻿using System;
using System.Dynamic;
using System.Linq;
using System.Linq.Expressions;
using D2MPMaster.LiveData;
using d2mpserver;

namespace D2MPMaster.Lobbies
{
    [AttributeUsage(AttributeTargets.Property|AttributeTargets.Field)]
    public class ExcludeFieldAttribute : System.Attribute
    {
        public string[] Collections
        {
            get { return colls; }
            set { colls = value; }
        }

        private string[] colls = null;
    }
    /// <summary>
    /// A lobby instance.
    /// </summary>
    public class Lobby
    {
        public string id { get; set; }
        public string name { get; set; }
        [ExcludeField(Collections = new []{"publicLobbies"})]
        public bool hasPassword { get; set; }
        [ExcludeField(Collections = new[] { "publicLobbies" })]
        public string password { get; set; }
        [ExcludeField(Collections = new[] { "publicLobbies" })]
        public string[] banned { get; set; }
        public string creator { get; set; }
        /// <summary>
        /// Creator UserID not SteamID
        /// </summary>
        public string creatorid { get; set; }
        public Player[] radiant { get; set; }
        public Player[] dire { get; set; }
        /// <summary>
        /// Mod ID not name (before would be "reflex" or "fof")
        /// </summary>
        public string mod { get; set; }
        [ExcludeField(Collections = new[] { "publicLobbies" })]
        public string serverIP { get; set; }
        public bool isPublic { get; set; }
        [ExcludeField(Collections = new[] { "publicLobbies" })]
        public bool requiresFullLobby { get; set; }
        public bool isRanked { get; set; }
        [ExcludeField(Collections = new[] { "publicLobbies", "lobbies" })]
        public bool devMode { get; set; }
        [ExcludeField(Collections = new[] { "publicLobbies", "lobbies" })]
        public bool enableGG { get; set; }
        [ExcludeField(Collections = new[] { "publicLobbies" })]
        public GameState state { get; set; }
        public ServerRegion region { get; set; }
        public LobbyStatus status { get; set; }
        [ExcludeField(Collections = new[] { "publicLobbies", "lobbies" })]
        public DateTime IdleSince { get; set; }
        public LobbyType LobbyType {get;set;}

        public int TeamCount(Player[] team)
        {
            return team.Count(plyr => plyr != null);
        }

        public void AddPlayer(Player[] p0, Player fromUser)
        {
            for (var i = 0; i < p0.Length; i++)
            {
                if (p0[i] != null) continue;
                p0[i] = fromUser;
                return;
            }
        }
    }
}
