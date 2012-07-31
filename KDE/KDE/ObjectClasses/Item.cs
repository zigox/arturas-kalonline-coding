using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArturasServer.KalOnline.DataEditor.ObjectClasses
{
    public enum PrimaryClass
    {
        General,
        Weapons,
        Defense,
        Money,
        Quest,
        Ornament,
        Transform,
    }

    public enum SecondaryClass
    {
        Charm,
        Etc,
        Sword,
        UpperArmor,
        Helmet,
        Gauntlet,
        Boots,
        LowerArmor,
        Bow,
        Shield,
        Coin,
        Refresh,
        Wand,
        Common,
        Trinket,
        Necklace,
        Ring,
        Repair,
        Cocoon,
        Mask,
        Sword2H,
        Standard,
        Fish,
        Dagger,
    }

    public enum Cocoon
    {
        A,
        B,
        C,
        D,
        E,
        F,
        G,
        H,
    }

    class Item
    {
        private System.Int32 _NameID;
        private System.Int32 _Index;
        private System.String _Image;
        private System.Int32 _Action1;
        private System.Int32 _Action2;
        private PrimaryClass _PrimaryClass;
        private SecondaryClass _SecondaryClass;
        private System.Int32 _Code1;
        private System.Int32 _Code2;
        private System.Int32 _Code3;
        private System.Int32 _Code4;
        private System.Int32 _Countries;
        private System.Int32 _Grade;
        private System.Boolean _Wear;
        private ArturasServer.KalOnline.DataEditor.ObjectClasses.ClassLimit _ClassLimit;
        private System.Int32 _LevelLimit;
        private System.Int32 _Range;
        private System.Int32 _Buy;
        private System.Int32 _Sell;
        private System.Int32 _Endurance;
        private System.Int32 _AttackSpeed;
        private System.Int32 _Attack1;
        private System.Int32 _Attack2;
        private System.Int32 _Attack3;
        private System.Int32 _Hit;
        private System.Int32 _Defense;
        private System.Int32 _Dodge;
        private System.Int32 _Absorb;
        private System.Int32 _WalkSpeed;
        private System.Int32 _RunSpeed;
        private Refresh _RefreshType;
        private System.Int32 _RefreshAmount;
        private System.Int32 _ResistFire;
        private System.Int32 _ResistIce;
        private System.Int32 _ResistLightning;
        private System.Int32 _Magic1;
        private System.Int32 _Magic2;
        private System.Int32 _Magic3;
        private System.Int32 _Health;
        private System.Int32 _Hp1;
        private System.Int32 _Hp2;
        private System.Int32 _Dexterity;
        private System.Int32 _ManaPoints;
        private System.Int32 _Intelligence;
        private System.Int32 _Wisdom;
        private System.Int32 _ResistCurse;
        private System.Int32 _ResistParalysis;
        private System.Int32 _Teleport1;
        private System.Int32 _Teleport2;
        private System.Int32 _Strength;
        private Charming _CharmingType;
        private System.Int32 _Repair1;
        private System.Int32 _Repair2;
        private System.Int32 _Buff1;
        private System.Int32 _BuffDuration;
        private System.Int32 _Buff3;
        private ArturasServer.KalOnline.DataEditor.ObjectClasses.ChangePrefixType _ChangePrefixType;
        private System.Int32 _Changeprefix2;
        private System.Int32 _Changeprefix3;
        private System.Int32 _Changeprefix4;
        private System.Int32 _Changeprefix5;
        private System.Int32 _Revival;
        private System.Int32 _GState;
        private System.Boolean _Plural;
        private System.Int32 _DescriptionID;
        private System.Boolean _Use;
        private System.Int32 _Cooltime1;
        private System.Int32 _Cooltime2;
        private System.Int32 _Effect;
        private System.Int32 _MaxProtect;
        private System.Int32 _Race;
        private ArturasServer.KalOnline.DataEditor.ObjectClasses.Cocoon _PrimaryCocoon;
        private ArturasServer.KalOnline.DataEditor.ObjectClasses.Cocoon _SecondaryCocoon;
        private ArturasServer.KalOnline.DataEditor.ObjectClasses.Cocoon _TertiaryCocoon;
        private ArturasServer.KalOnline.DataEditor.ObjectClasses.Cocoon _QuaternaryCocoon;
        private ArturasServer.KalOnline.DataEditor.ObjectClasses.Cocoon _QuinaryCocoon;
        private System.String _ImageEx1;
        private System.String _ImageEx2;
        private System.String _ImageEx3;
        private System.Boolean _Pay;
        private System.Int32 _Stbuff1;
        private System.Int32 _Stbuff2;
        private System.Boolean _WarRelation;
        public System.Int32 NameID { get { return _NameID; } set { _NameID = value; } }
        public System.Int32 Index { get { return _Index; } set { _Index = value; } }
        public System.String Image { get { return _Image; } set { _Image = value; } }
        public System.Int32 Action1 { get { return _Action1; } set { _Action1 = value; } }
        public System.Int32 Action2 { get { return _Action2; } set { _Action2 = value; } }
        public PrimaryClass PrimaryClass { get { return _PrimaryClass; } set { _PrimaryClass = value; } }
        public SecondaryClass SecondaryClass { get { return _SecondaryClass; } set { _SecondaryClass = value; } }
        public System.Int32 Code1 { get { return _Code1; } set { _Code1 = value; } }
        public System.Int32 Code2 { get { return _Code2; } set { _Code2 = value; } }
        public System.Int32 Code3 { get { return _Code3; } set { _Code3 = value; } }
        public System.Int32 Code4 { get { return _Code4; } set { _Code4 = value; } }
        public System.Int32 Countries { get { return _Countries; } set { _Countries = value; } }
        public System.Int32 Grade { get { return _Grade; } set { _Grade = value; } }
        public System.Boolean Wear { get { return _Wear; } set { _Wear = value; } }
        public ArturasServer.KalOnline.DataEditor.ObjectClasses.ClassLimit ClassLimit { get { return _ClassLimit; } set { _ClassLimit = value; } }
        public System.Int32 LevelLimit { get { return _LevelLimit; } set { _LevelLimit = value; } }
        public System.Int32 Range { get { return _Range; } set { _Range = value; } }
        public System.Int32 Buy { get { return _Buy; } set { _Buy = value; } }
        public System.Int32 Sell { get { return _Sell; } set { _Sell = value; } }
        public System.Int32 Endurance { get { return _Endurance; } set { _Endurance = value; } }
        public System.Int32 AttackSpeed { get { return _AttackSpeed; } set { _AttackSpeed = value; } }
        public System.Int32 Attack1 { get { return _Attack1; } set { _Attack1 = value; } }
        public System.Int32 Attack2 { get { return _Attack2; } set { _Attack2 = value; } }
        public System.Int32 Attack3 { get { return _Attack3; } set { _Attack3 = value; } }
        public System.Int32 Hit { get { return _Hit; } set { _Hit = value; } }
        public System.Int32 Defense { get { return _Defense; } set { _Defense = value; } }
        public System.Int32 Dodge { get { return _Dodge; } set { _Dodge = value; } }
        public System.Int32 Absorb { get { return _Absorb; } set { _Absorb = value; } }
        public System.Int32 WalkSpeed { get { return _WalkSpeed; } set { _WalkSpeed = value; } }
        public System.Int32 RunSpeed { get { return _RunSpeed; } set { _RunSpeed = value; } }
        public Refresh RefreshType { get { return _RefreshType; } set { _RefreshType = value; } }
        public System.Int32 RefreshAmount { get { return _RefreshAmount; } set { _RefreshAmount = value; } }
        public System.Int32 ResistFire { get { return _ResistFire; } set { _ResistFire = value; } }
        public System.Int32 ResistIce { get { return _ResistIce; } set { _ResistIce = value; } }
        public System.Int32 ResistLightning { get { return _ResistLightning; } set { _ResistLightning = value; } }
        public System.Int32 Magic1 { get { return _Magic1; } set { _Magic1 = value; } }
        public System.Int32 Magic2 { get { return _Magic2; } set { _Magic2 = value; } }
        public System.Int32 Magic3 { get { return _Magic3; } set { _Magic3 = value; } }
        public System.Int32 Health { get { return _Health; } set { _Health = value; } }
        public System.Int32 Hp1 { get { return _Hp1; } set { _Hp1 = value; } }
        public System.Int32 Hp2 { get { return _Hp2; } set { _Hp2 = value; } }
        public System.Int32 Dexterity { get { return _Dexterity; } set { _Dexterity = value; } }
        public System.Int32 ManaPoints { get { return _ManaPoints; } set { _ManaPoints = value; } }
        public System.Int32 Intelligence { get { return _Intelligence; } set { _Intelligence = value; } }
        public System.Int32 Wisdom { get { return _Wisdom; } set { _Wisdom = value; } }
        public System.Int32 ResistCurse { get { return _ResistCurse; } set { _ResistCurse = value; } }
        public System.Int32 ResistParalysis { get { return _ResistParalysis; } set { _ResistParalysis = value; } }
        public System.Int32 Teleport1 { get { return _Teleport1; } set { _Teleport1 = value; } }
        public System.Int32 Teleport2 { get { return _Teleport2; } set { _Teleport2 = value; } }
        public System.Int32 Strength { get { return _Strength; } set { _Strength = value; } }
        public ArturasServer.KalOnline.DataEditor.ObjectClasses.Charming CharmingType { get { return _CharmingType; } set { _CharmingType = value; } }
        public System.Int32 Repair1 { get { return _Repair1; } set { _Repair1 = value; } }
        public System.Int32 Repair2 { get { return _Repair2; } set { _Repair2 = value; } }
        public System.Int32 Buff1 { get { return _Buff1; } set { _Buff1 = value; } }
        public System.Int32 BuffDuration { get { return _BuffDuration; } set { _BuffDuration = value; } }
        public System.Int32 Buff3 { get { return _Buff3; } set { _Buff3 = value; } }
        public ArturasServer.KalOnline.DataEditor.ObjectClasses.ChangePrefixType ChangePrefixType { get { return _ChangePrefixType; } set { _ChangePrefixType = value; } }
        public System.Int32 Changeprefix2 { get { return _Changeprefix2; } set { _Changeprefix2 = value; } }
        public System.Int32 Changeprefix3 { get { return _Changeprefix3; } set { _Changeprefix3 = value; } }
        public System.Int32 Changeprefix4 { get { return _Changeprefix4; } set { _Changeprefix4 = value; } }
        public System.Int32 Changeprefix5 { get { return _Changeprefix5; } set { _Changeprefix5 = value; } }
        public System.Int32 Revival { get { return _Revival; } set { _Revival = value; } }
        public System.Int32 GState { get { return _GState; } set { _GState = value; } }
        public System.Boolean Plural { get { return _Plural; } set { _Plural = value; } }
        public System.Int32 DescriptionID { get { return _DescriptionID; } set { _DescriptionID = value; } }
        public System.Boolean Use { get { return _Use; } set { _Use = value; } }
        public System.Int32 Cooltime1 { get { return _Cooltime1; } set { _Cooltime1 = value; } }
        public System.Int32 Cooltime2 { get { return _Cooltime2; } set { _Cooltime2 = value; } }
        public System.Int32 Effect { get { return _Effect; } set { _Effect = value; } }
        public System.Int32 MaxProtect { get { return _MaxProtect; } set { _MaxProtect = value; } }
        public System.Int32 Race { get { return _Race; } set { _Race = value; } }
        public ArturasServer.KalOnline.DataEditor.ObjectClasses.Cocoon PrimaryCocoon { get { return _PrimaryCocoon; } set { _PrimaryCocoon = value; } }
        public ArturasServer.KalOnline.DataEditor.ObjectClasses.Cocoon SecondaryCocoon { get { return _SecondaryCocoon; } set { _SecondaryCocoon = value; } }
        public ArturasServer.KalOnline.DataEditor.ObjectClasses.Cocoon TertiaryCocoon { get { return _TertiaryCocoon; } set { _TertiaryCocoon = value; } }
        public ArturasServer.KalOnline.DataEditor.ObjectClasses.Cocoon QuaternaryCocoon { get { return _QuaternaryCocoon; } set { _QuaternaryCocoon = value; } }
        public ArturasServer.KalOnline.DataEditor.ObjectClasses.Cocoon QuinaryCocoon { get { return _QuinaryCocoon; } set { _QuinaryCocoon = value; } }
        public System.String ImageEx1 { get { return _ImageEx1; } set { _ImageEx1 = value; } }
        public System.String ImageEx2 { get { return _ImageEx2; } set { _ImageEx2 = value; } }
        public System.String ImageEx3 { get { return _ImageEx3; } set { _ImageEx3 = value; } }
        public System.Boolean Pay { get { return _Pay; } set { _Pay = value; } }
        public System.Int32 Stbuff1 { get { return _Stbuff1; } set { _Stbuff1 = value; } }
        public System.Int32 Stbuff2 { get { return _Stbuff2; } set { _Stbuff2 = value; } }
        public System.Boolean WarRelation { get { return _WarRelation; } set { _WarRelation = value; } }

    }
}
