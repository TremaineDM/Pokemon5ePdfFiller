using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using Google.Protobuf.WellKnownTypes;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Status;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using System.Reflection;
using Newtonsoft.Json.Linq;

namespace Pokemon5ePdfFiller
{
    public class Hp
    {
        public string? Current_hp;
        public string? Temp_hp;
        public string? Max_hp;
    }

    public class Ability
    {
        public string? Name;
        public string? Description;
    }

    public class Attributes
    {
        public string? STR;
        public string? DEX;
        public string? CON;
        public string? INT;
        public string? WIS;
        public string? CHA;
    }

    public class PP
    {
        public string? Max_PP;
        public string? Current_PP;
    }

    public class Saves
    {
        public string? Save_dc;
        public string? Save_ability;
    }

    public class Move
    {
        public string? Name;
        public string? Description;
        public string? Type;
        public string? Duration;
        public string? Range;
        public string? Time;
        public PP? pp;
        public List<string>? Power;
        public string? Damage;
        public Saves? Saves;
        public string? Attack_bonus;
    }

    public class Speeds
    {
        public string? Flying;
        public string? Walking;
        public string? Climbing;
        public string? Swimming;
        public string? Burrow;
    }

    public class Pokemon
    {
		public Dictionary<string, string> StringMap = new Dictionary<string, string>();
		public Dictionary<string, string> ExtraStringMap = new Dictionary<string, string>();
		public Dictionary<string, List<string>> StringListMap = new Dictionary<string, List<string>>();
		public Dictionary<string, List<string>> ExtraStringListMap = new Dictionary<string, List<string>>();

        public Hp? Hp;
        public Speeds? Speeds;
        public Attributes? Attributes;
        public Attributes? Saving_throws;

        public List<Ability>? Abilities;
        public List<Ability>? Feats;
        public List<Move>? Moves;
    }
}