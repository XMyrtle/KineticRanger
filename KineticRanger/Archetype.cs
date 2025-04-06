using BlueprintCore.Blueprints.CustomConfigurators.Classes;
using BlueprintCore.Blueprints.References;
using BlueprintCore.Utils.Types;
using Kingmaker.Blueprints.Classes.Prerequisites;
using Kingmaker.EntitySystem.Stats;
using Kingmaker.UnitLogic;

namespace KineticRanger
{
    class Archetype
    {
        public static void Configure()
        {
            ArchetypeConfigurator.New(name: "KineticRanger", guid: Guids.Archetype, clazz: CharacterClassRefs.KineticistClass)
            .AddPrerequisiteNoClassLevel(characterClass: CharacterClassRefs.AnimalClass.ToString(),
                                        group: Prerequisite.GroupType.All)
            .AddPrerequisiteIsPet(not: true,
                                  hideInUI: true,
                                  group: Prerequisite.GroupType.All)
            .SetLocalizedName("KineticRanger_Name")
            .SetLocalizedDescription("KineticRanger_Desc")
            .SetReplaceSpellbook(Guids.SpellBook)
            .SetAddFeatures(LevelEntryBuilder.New()
                            .AddEntry(1, [Guids.RangerBurnFeature,
                                          ProgressionRefs.MentalOverflowProgression.ToString()])
                            .AddEntry(4, [FeatureRefs.SkilledKineticistFeature.ToString(),
                                          Guids.KineticRangerBond,])
                            .AddEntry(6, [FeatureRefs.BrewPotions.ToString()]))
            .SetRemoveFeatures(LevelEntryBuilder.New().
                                AddEntry(level: 1, features: [FeatureRefs.BurnFeature.ToString(),
                                                              ProgressionRefs.ElementalOverflowProgression.ToString()]))
            .SetReplaceClassSkills(true)
            .SetClassSkills([StatType.SkillKnowledgeArcana,
                             StatType.SkillLoreNature,
                             StatType.SkillThievery,
                             StatType.SkillMobility,
                             StatType.SkillPersuasion,
                             StatType.SkillStealth,
                             StatType.SkillUseMagicDevice,
                             StatType.SkillPerception])
            .SetChangeCasterType(true)
            .SetIsDivineCaster(true)
            .SetAddSkillPoints(2)
            .SetOverrideAttributeRecommendations(true)
            .SetRecommendedAttributes([StatType.Dexterity,
                                       StatType.Charisma])
            .SetBaseAttackBonus("4c936de4249b61e419a3fb775b9f2581")
            .SetFortitudeSave("ff4662bde9e75f145853417313842751")
            .SetReflexSave("ff4662bde9e75f145853417313842751")
            .SetWillSave("dc0c7c1aba755c54f96c089cdf7d14a3")
            .SetDifficulty(1)
            .SetBuildChanging(true)
            .Configure();


            FeatureConfigurator.For(FeatureRefs.SkilledKineticistFeature)
            .AddPrerequisiteNoArchetype(archetype: Guids.Archetype, characterClass: CharacterClassRefs.KineticistClass.ToString())
            .Configure();

            FeatureConfigurator.For(FeatureRefs.BrewPotions)
            .AddPrerequisiteNoArchetype(archetype: Guids.Archetype, characterClass: CharacterClassRefs.KineticistClass.ToString())
            .Configure();

        }

    }

}