using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole
{
    public enum Race { Human, Elf, HalfElf, Tiefling, Dwarf, Dragonborn, Halfling, Gnome, HalfOrk}
    public class Character
    {
        private int _str;
        private int _dex;
        private int _con;
        private int _int;
        private int _wis;
        private int _cha;
        private int _level;
        private int _prof;
        private int _carryingCapacity;
        private int _ac;
        private int _speed;
        private string _name;
        private string _playerName;
        private Race _raceType;

        public int Str { get => _str; set => _str = value; }
        public int Dex { get => _dex; set => _dex = value; }
        public int Con { get => _con; set => _con = value; }
        public int Int { get => _int; set => _int = value; }
        public int Wis { get => _wis; set => _wis = value; }
        public int Cha { get => _cha; set => _cha = value; }
        public int CarryingCapacity { get => _carryingCapacity; set => _carryingCapacity = Str * 15; }
        public string Name { get => _name; set => _name = value; }
        public string PlayerName { get => _playerName; set => _playerName = value; }
        public Race RaceType { get => _raceType; set => _raceType = value; }
        public int Level { get => _level; set => _level = value; }
        public int Prof { get => _prof; set => _prof = value; }
        public int AC { get => _ac; set => _ac = value; }
        public int Speed { get => _speed; set => _speed = value; }


        /// <summary>
        /// Create new Character
        /// </summary>
        /// <param name="str">Strength</param>
        /// <param name="dex">Dexterity</param>
        /// <param name="con">Constitution</param>
        /// <param name="int">Intelligence</param>
        /// <param name="wis">Wisdom</param>
        /// <param name="cha">Charisma</param>
        /// <param name="name">Name</param>
        /// <param name="playerName">Player-Name</param>
        /// <param name="raceType">Race</param>
        public Character(int str, int dex, int con, int @int, int wis, int cha, string name, string playerName, Race raceType = Race.Human)
        {
            if(string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException(message: "Character name cannot be null or empty.", paramName: nameof(name));
            }
            if (string.IsNullOrWhiteSpace(playerName))
            {
                throw new ArgumentException(message: "Player name cannot be null or empty.", paramName: nameof(playerName));
            }

            CheckStats(str);
            CheckStats(dex);
            CheckStats(con);
            CheckStats(@int);
            CheckStats(wis);
            CheckStats(cha);

            Str = str;
            Dex = dex;
            Con = con;
            Int = @int;
            Wis = wis;
            Cha = cha;
            Name = name;
            PlayerName = playerName;
            RaceType = raceType;
            Speed = 30;
            AC = 10;
            // Necessary for first addition
            CarryingCapacity = 0;
            Level = 20;
            CalcProf();
        }

        private void CheckStats(int stat)
        {
            if (stat < 1 || stat > 30)
                throw new ArgumentException(message: "Stat cannot be lower than 1 or higher than 30.", paramName: nameof(stat));
        }
        
        public void Update()
        {
            CalcProf();
        }

        private void CalcProf()
        {
            if (Level >= 1 && Level <= 4)
                Prof = 2;
            else if (Level >= 5 && Level <= 8)
                Prof = 3;
            else if (Level >= 9 && Level <= 12)
                Prof = 4;
            else if (Level >= 13 && Level <= 16)
                Prof = 5;
            else if (Level >= 17 && Level <= 20)
                Prof = 6;
        }

    }
}
