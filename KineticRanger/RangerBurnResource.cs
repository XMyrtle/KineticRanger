using BlueprintCore.Blueprints.CustomConfigurators;
using BlueprintCore.Blueprints.References;
using Kingmaker.EntitySystem.Stats;

namespace KineticRanger
{
    class RangerBurnResource
    {
        public static void Configure()
        {
            AbilityResourceConfigurator.New(name: "RangerBurnResource", guid: Guids.RangerBurnResource)
            .SetMaxAmount(ResourceAmountBuilder.New(3)
            .IncreaseByStat(StatType.Charisma))
            .Configure();
        }


    }

}