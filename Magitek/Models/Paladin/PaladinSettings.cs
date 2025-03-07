﻿using Magitek.Enumerations;
using Magitek.Models.Roles;
using PropertyChanged;
using System.ComponentModel;
using System.Configuration;

namespace Magitek.Models.Paladin
{
    [AddINotifyPropertyChangedInterface]
    public class PaladinSettings : TankSettings, IRoutineSettings
    {
        public PaladinSettings() : base(CharacterSettingsDirectory + "/Magitek/Paladin/PaladinSettings.json") { }
        public static PaladinSettings Instance { get; set; } = new PaladinSettings();

        [Setting]
        [DefaultValue(70.0f)]
        public float RestHealthPercent { get; set; }

        [Setting]
        [DefaultValue(true)]
        public bool UseFightOrFlight { get; set; }

        [Setting]
        [DefaultValue(false)]
        public bool IronWill { get; set; }

        [Setting]
        [DefaultValue(7)]
        public int RefreshGoringBlade { get; set; }

        [Setting]
        [DefaultValue(4000)]
        public int HealthSetting { get; set; }

        [Setting]
        [DefaultValue(true)]
        public bool FoFFastBlade { get; set; }

        [Setting]
        [DefaultValue(20.0f)]
        public float HealthSettingPercent { get; set; }

        [Setting]
        [DefaultValue(true)]
        public bool TotalEclipse { get; set; }

        [Setting]
        [DefaultValue(true)]
        public bool Prominance { get; set; }

        [Setting]
        [DefaultValue(true)]
        public bool HolyCircle { get; set; }

        [Setting]
        [DefaultValue(3)]
        public int TotalEclipseEnemies { get; set; }

        [Setting]
        [DefaultValue(true)]
        public bool HolySpirit { get; set; }

        [Setting]
        [DefaultValue(true)]
        public bool HolySpiritWhenOutOfMeleeRange { get; set; }

        [Setting]
        [DefaultValue(true)]
        public bool UseConfiteor { get; set; }

        [Setting]
        [DefaultValue(true)]
        public bool Requiescat { get; set; }

        [Setting]
        [DefaultValue(1)]
        public int RequiescatWithFofSecondsRemaining { get; set; }

        [Setting]
        [DefaultValue(false)]
        public bool UseShieldLob { get; set; }

        [Setting]
        [DefaultValue(true)]
        public bool ShieldLobToPull { get; set; }

        [Setting]
        [DefaultValue(true)]
        public bool ShieldLobLostAggro { get; set; }

        [Setting]
        [DefaultValue(false)]
        public bool ShieldLobToPullExtraEnemies { get; set; }

        [Setting]
        [DefaultValue(true)]
        public bool UseCover { get; set; }

        [Setting]
        [DefaultValue(true)]
        public bool UseCoverHealer { get; set; }

        [Setting]
        [DefaultValue(50.0f)]
        public float UseCoverHealerHp { get; set; }

        [Setting]
        [DefaultValue(true)]
        public bool UseCoverDps { get; set; }

        [Setting]
        [DefaultValue(50.0f)]
        public float UseCoverDpsHp { get; set; }

        [Setting]
        [DefaultValue(true)]
        public bool HallowGround { get; set; }

        [Setting]
        [DefaultValue(25.0f)]
        public float HallowGroundHp { get; set; }

        [Setting]
        [DefaultValue(true)]
        public bool Sentinel { get; set; }

        [Setting]
        [DefaultValue(true)]
        public bool FoFFirst { get; set; }


        [Setting]
        [DefaultValue(true)]
        public bool Intervene { get; set; }

        [Setting]
        [DefaultValue(true)]
        public bool InterveneOnlyInMelee { get; set; }

        [Setting]
        [DefaultValue(0)]
        public int SaveInterveneCharges { get; set; }

        [Setting]
        [DefaultValue(true)]
        public bool AoE { get; set; }


        [Setting]
        [DefaultValue(70.0f)]
        public float SentinelHp { get; set; }

        [Setting]
        [DefaultValue(true)]
        public bool DivineVeil { get; set; }

        [Setting]
        [DefaultValue(80.0f)]
        public float DivineVeilHp { get; set; }

        [Setting]
        [DefaultValue(true)]
        public bool Sheltron { get; set; }

        [Setting]
        [DefaultValue(80.0f)]
        public float SheltronHp { get; set; }

        [Setting]
        [DefaultValue(true)]
        public bool SpiritsWithin { get; set; }

        [Setting]
        [DefaultValue(true)]
        public bool InterventionOnNearbyPartyMember { get; set; }

        [Setting]
        [DefaultValue(50.0f)]
        public float InterventionOnNearbyPartyMemberHealth { get; set; }

        [Setting]
        [DefaultValue(true)]
        public bool InterventionPartyAlwaysWOCD { get; set; }

        [Setting]
        [DefaultValue(true)]
        public bool InterventionPartyAlwaysWithCD { get; set; }

        [Setting]
        [DefaultValue(true)]
        public bool ShieldBash { get; set; }

        [Setting]
        [DefaultValue(true)]
        public bool UseClemency { get; set; }

        [Setting]
        [DefaultValue(true)]
        public bool UseClemencyHealer { get; set; }

        [Setting]
        [DefaultValue(30.0f)]
        public float UseClemencyHealerHp { get; set; }

        [Setting]
        [DefaultValue(true)]
        public bool UseClemencyDps { get; set; }

        [Setting]
        [DefaultValue(30.0f)]
        public float UseClemencyDpsHp { get; set; }

        [Setting]
        [DefaultValue(true)]
        public bool UseClemencySelf { get; set; }

        [Setting]
        [DefaultValue(30.0f)]
        public float UseClemencySelfHp { get; set; }

        [Setting]
        [DefaultValue(50.0f)]
        public float MinMpClemency { get; set; }

        [Setting]
        [DefaultValue(true)]
        public bool CircleOfScorn { get; set; }

        [Setting]
        [DefaultValue(PaladinOpenerStrategy.AlwaysUseOpener)]
        public PaladinOpenerStrategy PaladinOpenerStrategy { get; set; }

        #region PVP
        [Setting]
        [DefaultValue(true)]
        public bool Testudo { get; set; }

        [Setting]
        [DefaultValue(2)]
        public int TestudoAllies { get; set; }

        [Setting]
        [DefaultValue(80.0f)]
        public float TestudoHealth { get; set; }

        [Setting]
        [DefaultValue(true)]
        public bool PushBack { get; set; }

        [Setting]
        [DefaultValue(true)]
        public bool GlorySlash { get; set; }

        [Setting]
        [DefaultValue(true)]
        public bool FullSwing { get; set; }
        #endregion
    }
}
