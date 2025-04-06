using BlueprintCore.Blueprints.CustomConfigurators.Classes;
using BlueprintCore.Blueprints.CustomConfigurators.Classes.Selection;
using BlueprintCore.Blueprints.References;
using Kingmaker.Blueprints.Classes;
using Kingmaker.Blueprints.JsonSystem.Converters;

namespace KineticRanger
{
    class KineticRangerBond
    {
        public static void Configure()
        {
            FeatureSelectionConfigurator.New(name: "KineticRangerBond", guid: Guids.KineticRangerBond)
            .CopyFrom(FeatureSelectionRefs.AnimalCompanionSelectionRanger)
            .AddFeatureOnApply(feature: ProgressionRefs.RangerAnimalCompanionProgression.ToString())
            .AddFeatureOnApply(feature: FeatureRefs.MountTargetFeature.ToString())
            .AddFeatureOnApply(feature: FeatureSelectionRefs.AnimalCompanionArchetypeSelection.ToString())
            .AddFeatureOnApply(feature: FeatureRefs.AnimalCompanionBondBonus.ToString())
            .SetIcon(FeatureSelectionRefs.AnimalCompanionSelectionRanger.Reference.Get().Icon)
            .SetIsClassFeature(true)
            .SetRanks(1)
            .SetGroup(FeatureGroup.AnimalCompanion)
            .SetAllFeatures([FeatureRefs.AnimalCompanionEmptyCompanion.ToString(),
                             FeatureRefs.AnimalCompanionFeatureBear.ToString(),
                             FeatureRefs.AnimalCompanionFeatureBoar.ToString(),
                             FeatureRefs.AnimalCompanionFeatureCentipede.ToString(),
                             FeatureRefs.AnimalCompanionFeatureDog.ToString(),
                             FeatureRefs.AnimalCompanionFeatureElk.ToString(),
                             FeatureRefs.AnimalCompanionFeatureHorse.ToString(),
                             FeatureRefs.AnimalCompanionFeatureLeopard.ToString(),
                             FeatureRefs.AnimalCompanionFeatureMammoth.ToString(),
                             FeatureRefs.AnimalCompanionFeatureMonitor.ToString(),
                             FeatureRefs.AnimalCompanionFeatureSmilodon.ToString(),
                             FeatureRefs.AnimalCompanionFeatureTriceratops.ToString(),
                             FeatureRefs.AnimalCompanionFeatureVelociraptor.ToString(),
                             FeatureRefs.AnimalCompanionFeatureWolf.ToString(),
                             FeatureRefs.AnimalCompanionFeatureHorse_PreorderBonus.ToString(),
                             FeatureRefs.AnimalCompanionFeatureSmilodon_PreorderBonus.ToString(),
                             FeatureRefs.AnimalCompanionFeatureTriceratops_PreorderBonus.ToString()])
            .SetDisplayName("KineticRangerBond_Name")
            .SetDescription("KineticRangerBond_Desc")
            .Configure();
        }

    }

}