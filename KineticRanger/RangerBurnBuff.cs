using BlueprintCore.Blueprints.CustomConfigurators.UnitLogic.Buffs;
using BlueprintCore.Blueprints.References;
using BlueprintCore.Utils.Types;
using Kingmaker.EntitySystem.Stats;
using Kingmaker.Enums;
using Kingmaker.UnitLogic.Buffs.Blueprints;

namespace KineticRanger
{
    class RangerBurnBuff
    {
        public static void Configure()
        {
            BuffConfigurator.New(name: "RangerBurnBuff", guid: Guids.RangerBurnBuff)
            .AddContextRankConfig(ContextRankConfigs.CustomProperty(property: UnitPropertyRefs.BurnNumberProperty.ToString(),
                                                                    type: AbilityRankType.Default)
                                  .WithMultiplyByModifierProgression(multiplier: 1))
            .AddContextStatBonus(stat: StatType.SkillPersuasion,
                                 multiplier: -2,
                                 value: ContextValues.Rank())
            .AddContextStatBonus(stat: StatType.SkillUseMagicDevice,
                                 multiplier: -2,
                                 value: ContextValues.Rank())
            .AddToFlags([BlueprintBuff.Flags.HiddenInUi,
                         BlueprintBuff.Flags.StayOnDeath,
                         BlueprintBuff.Flags.RemoveOnRest])
            .SetStacking(StackingType.Replace)
            .Configure();
        }

    }

}