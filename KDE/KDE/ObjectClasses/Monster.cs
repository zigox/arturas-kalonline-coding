using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ComponentModel;

namespace ArturasServer.KalOnline.DataEditor.ObjectClasses
{
    [Serializable]
    public class Monster : ObjectClass
    {
        private int _NameID;
        private int _Index;
        private List<int> _Countries = new List<int>();
        private int _Race;
        private int _Level;
        private int _AI;
        private int _Range;
        private int _SightMin;
        private int _SightMax;
        private int _EXP;
        private List<int> _ItemGroups = new List<int>();
        private int _Strength;
        private int _Health;
        private int _Intelligence;
        private int _Wisdom;
        private int _Dexterity;
        private int _HP;
        private int _MP;
        private int _AttackSpeed;
        private int _OTP;
        private int _Dodge;
        private int _Attack1;
        private int _Attack2;
        private int _Attack3;
        private int _MagicMin;
        private int _MagicMax;
        private int _DefenceMin;
        private int _DefenceMax;
        private int _Absorb;
        private int _WalkSpeed;
        private int _RunSpeed;
        private int _Resist1;
        private int _Resist2;
        private int _Resist3;
        private int _Resist4;
        private int _Resist5;
        private int _SkillInfo1;
        private int _SkillInfo2;
        private int _SkillInfo3;
        private int _SkillInfo4;
        private List<MonsterSkill> _Skills = new List<MonsterSkill>();
        private List<MonsterQuest> _Quests = new List<MonsterQuest>();

        [CategoryAttribute("Display")]
        public MonsterName Name
        {
            get
            {
                var selectedMonsterNames =
                    from o in ObjectClassManager.ObjectClasses
                    where o.GetType() == typeof(MonsterName)
                    where ((MonsterName)o).Index == NameID
                    select o;

                foreach(MonsterName monsterName in selectedMonsterNames)
                {
                    return monsterName;
                }

                return null;
            }
        }

        public override Dictionary<string, ObjectClass> GetLinks
        {
            get
            {
                Dictionary<string, ObjectClass> links = new Dictionary<string, ObjectClass>();
                links.Add("Name", Name);
                return links;
            }
        }

        public override string ToString()
        {
            if (Name == null)
            {
                return "Unknown Monster";
            }
            else
            {
                return Name.Value;
            }
        }

        [CategoryAttribute("Display")]
        public int NameID
        {
            get { return _NameID; }
            set { _NameID = value; }
        }

        [CategoryAttribute("System")]
        public int Index
        {
            get { return _Index; }
            set { _Index = value; }
        }

        [CategoryAttribute("System")]
        public List<int> Countries
        {
            get { return _Countries; }
            set { _Countries = value; }
        }

        [CategoryAttribute("Display")]
        public int Race
        {
            get { return _Race; }
            set { _Race = value; }
        }

        [CategoryAttribute("Stats")]
        public int Level
        {
            get { return _Level; }
            set { _Level = value; }
        }

        [CategoryAttribute("Behavior")]
        public int AI
        {
            get { return _AI; }
            set { _AI = value; }
        }

        [CategoryAttribute("Stats")]
        public int Range
        {
            get { return _Range; }
            set { _Range = value; }
        }

        [CategoryAttribute("Behavior")]
        public int SightMin
        {
            get { return _SightMin; }
            set { _SightMin = value; }
        }

        [CategoryAttribute("Behavior")]
        public int SightMax
        {
            get { return _SightMax; }
            set { _SightMax = value; }
        }

        [CategoryAttribute("Stats")]
        public int EXP
        {
            get { return _EXP; }
            set { _EXP = value; }
        }

        [CategoryAttribute("System")]
        public List<int> ItemGroups
        {
            get { return _ItemGroups; }
            set { _ItemGroups = value; }
        }

        [CategoryAttribute("Stats")]
        public int Strength
        {
            get { return _Strength; }
            set { _Strength = value; }
        }

        [CategoryAttribute("Stats")]
        public int Health
        {
            get { return _Health; }
            set { _Health = value; }
        }

        [CategoryAttribute("Stats")]
        public int Intelligence
        {
            get { return _Intelligence; }
            set { _Intelligence = value; }
        }

        [CategoryAttribute("Stats")]
        public int Wisdom
        {
            get { return _Wisdom; }
            set { _Wisdom = value; }
        }

        [CategoryAttribute("Stats")]
        public int Dexterity
        {
            get { return _Dexterity; }
            set { _Dexterity = value; }
        }

        [CategoryAttribute("Stats")]
        public int HP
        {
            get { return _HP; }
            set { _HP = value; }
        }

        [CategoryAttribute("Stats")]
        public int MP
        {
            get { return _MP; }
            set { _MP = value; }
        }

        [CategoryAttribute("Stats")]
        public int AttackSpeed
        {
            get { return _AttackSpeed; }
            set { _AttackSpeed = value; }
        }

        [CategoryAttribute("Stats")]
        public int OTP
        {
            get { return _OTP; }
            set { _OTP = value; }
        }

        [CategoryAttribute("Stats")]
        public int Dodge
        {
            get { return _Dodge; }
            set { _Dodge = value; }
        }

        [CategoryAttribute("Action")]
        public int Attack1
        {
            get { return _Attack1; }
            set { _Attack1 = value; }
        }

        [CategoryAttribute("Action")]
        public int Attack2
        {
            get { return _Attack2; }
            set { _Attack2 = value; }
        }

        [CategoryAttribute("Action")]
        public int Attack3
        {
            get { return _Attack3; }
            set { _Attack3 = value; }
        }

        [CategoryAttribute("Action")]
        public int MagicMin
        {
            get { return _MagicMin; }
            set { _MagicMin = value; }
        }

        [CategoryAttribute("Action")]
        public int MagicMax
        {
            get { return _MagicMax; }
            set { _MagicMax = value; }
        }

        [CategoryAttribute("Action")]
        public int DefenceMin
        {
            get { return _DefenceMin; }
            set { _DefenceMin = value; }
        }

        [CategoryAttribute("Action")]
        public int DefenceMax
        {
            get { return _DefenceMax; }
            set { _DefenceMax = value; }
        }

        [CategoryAttribute("Stats")]
        public int Absorb
        {
            get { return _Absorb; }
            set { _Absorb = value; }
        }

        [CategoryAttribute("Behavior")]
        public int WalkSpeed
        {
            get { return _WalkSpeed; }
            set { _WalkSpeed = value; }
        }

        [CategoryAttribute("Behavior")]
        public int RunSpeed
        {
            get { return _RunSpeed; }
            set { _RunSpeed = value; }
        }

        [CategoryAttribute("Resistance")]
        public int Resist1
        {
            get { return _Resist1; }
            set { _Resist1 = value; }
        }

        [CategoryAttribute("Resistance")]
        public int Resist2
        {
            get { return _Resist2; }
            set { _Resist2 = value; }
        }

        [CategoryAttribute("Resistance")]
        public int Resist3
        {
            get { return _Resist3; }
            set { _Resist3 = value; }
        }

        [CategoryAttribute("Resistance")]
        public int Resist4
        {
            get { return _Resist4; }
            set { _Resist4 = value; }
        }

        [CategoryAttribute("Resistance")]
        public int Resist5
        {
            get { return _Resist5; }
            set { _Resist5 = value; }
        }

        [CategoryAttribute("Skill Info")]
        public int SkillInfo1
        {
            get { return _SkillInfo1; }
            set { _SkillInfo1 = value; }
        }

        [CategoryAttribute("Skill Info")]
        public int SkillInfo2
        {
            get { return _SkillInfo2; }
            set { _SkillInfo2 = value; }
        }

        [CategoryAttribute("Skill Info")]
        public int SkillInfo3
        {
            get { return _SkillInfo3; }
            set { _SkillInfo3 = value; }
        }

        [CategoryAttribute("Skill Info")]
        public int SkillInfo4
        {
            get { return _SkillInfo4; }
            set { _SkillInfo4 = value; }
        }

        [CategoryAttribute("Quests")]
        public List<MonsterQuest> Quests
        {
            get { return _Quests; }
            set { _Quests = value; }
        }

        [CategoryAttribute("Skills")]
        public List<MonsterSkill> Skills
        {
            get { return _Skills; }
            set { _Skills = value; }
        }

    }
}
