using System;
using BlueprintCore.Actions.Builder;
using BlueprintCore.Actions.Builder.ContextEx;
using BlueprintCore.Blueprints.CustomConfigurators.Classes;
using BlueprintCore.Blueprints.References;
using BlueprintCore.Utils;
using Kingmaker.Blueprints;
using Kingmaker.Designers.Mechanics.Facts;
using Kingmaker.EntitySystem.Stats;
using Kingmaker.UnitLogic.Class.Kineticist;

namespace KineticRanger
{
    class RangerBurnFeature
    {
        public static void Configure()
        {
            FeatureConfigurator.New(name: "KineticRangerBurn", guid: Guids.RangerBurnFeature)
            .AddAbilityResources(resource: Guids.RangerBurnResource,
                                 amount: 0)
            .AddKineticistPart(clazz: CharacterClassRefs.KineticistClass.ToString(),
                                mainStat: StatType.Charisma,
                                maxBurn: Guids.RangerBurnResource,
                                maxBurnPerRound: AbilityResourceRefs.BurnPerRoundResource.ToString(),
                                gatherPowerAbility: FeatureRefs.GatherPowerFeature.ToString(),
                                gatherPowerBuff1: BuffRefs.GatherPowerBuffI.ToString(),
                                gatherPowerBuff2: BuffRefs.GatherPowerBuffII.ToString(),
                                gatherPowerBuff3: BuffRefs.GatherPowerBuffIII.ToString(),
                                blasts: [AbilityRefs.AirBlastBase.ToString(),
                                         AbilityRefs.BlizzardBlastBase.ToString(),
                                         AbilityRefs.BlueFlameBlastBase.ToString(),
                                         AbilityRefs.ChargedWaterBlastBase.ToString(),
                                         AbilityRefs.ColdBlastBase.ToString(),
                                         AbilityRefs.EarthBlastBase.ToString(),
                                         AbilityRefs.ElectricBlastBase.ToString(),
                                         AbilityRefs.FireBlastBase.ToString(),
                                         AbilityRefs.IceBlastBase.ToString(),
                                         AbilityRefs.MagmaBlastBase.ToString(),
                                         AbilityRefs.MetalBlastBase.ToString(),
                                         AbilityRefs.MudBlastBase.ToString(),
                                         AbilityRefs.PlasmaBlastBase.ToString(),
                                         AbilityRefs.SandstormBlastBase.ToString(),
                                         AbilityRefs.SteamBlastBase.ToString(),
                                         AbilityRefs.ThunderstormBlastBase.ToString(),
                                         AbilityRefs.WaterBlastBase.ToString()],
                                bladeActivatedBuff: BuffRefs.KineticBladeEnableBuff.ToString(),
                                canGatherPowerWithShieldBuff: null)
            .AddAbilityResources(resource: AbilityResourceRefs.BurnPerRoundResource.ToString())
            .AddKineticistBurnValueChangedTrigger(action: ActionsBuilder.New()
                                                        .ApplyBuffPermanent(buff: Guids.RangerBurnBuff))
            .SetDisplayName("RangerBurn_Name")
            .SetDescription("RangerBurn_Desc")
            .Configure();

        }

    }

}