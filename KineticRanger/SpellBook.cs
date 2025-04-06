using BlueprintCore.Blueprints.Configurators.Classes;
using BlueprintCore.Blueprints.Configurators.Classes.Spells;
using BlueprintCore.Blueprints.CustomConfigurators.Classes.Spells;
using BlueprintCore.Blueprints.References;
using BlueprintCore.Utils;
using Kingmaker.Blueprints;
using Kingmaker.Blueprints.Classes.Spells;
using Kingmaker.EntitySystem.Stats;

namespace KineticRanger
{
    class SpellBook
    {
        public static void Configure()
        {
            SpellsTableConfigurator.New(name: "KineticRangerSpellLeves", Guids.SpellLevels)
            .SetLevels(GetSpellLevelList())
            .Configure();

            SpellListConfigurator.New(name: "KineticRangerSpellList", Guids.SpellList)
            .SetSpellsByLevel(GetSpellList())
            .Configure();

            SpellbookConfigurator.New(name: "KineticRangerSpellBook", guid: Guids.SpellBook)
            .SetSpellsPerDay(Guids.SpellLevels)
            .SetSpellList(SpellListRefs.RangerSpellList.ToString())
            .SetCharacterClass(CharacterClassRefs.KineticistClass.ToString())
            .SetCastingAttribute(StatType.Charisma)
            .SetSpontaneous(false)
            .SetSpellsPerLevel(0)
            .SetAllSpellsKnown(true)
            .SetCantripsType(CantripsType.Cantrips)
            .SetCasterLevelModifier(-3)
            .SetName("SpellBook_Name")
            .Configure();

            FeatureSelectMythicSpellbookConfigurator.For(FeatureSelectMythicSpellbookRefs.AngelIncorporateSpellbook.ToString())
            .AddToAllowedSpellbooks(Guids.SpellBook)
            .Configure();
            FeatureSelectMythicSpellbookConfigurator.For(FeatureSelectMythicSpellbookRefs.LichIncorporateSpellbookFeature.ToString())
            .AddToAllowedSpellbooks(Guids.SpellBook)
            .Configure();
        }
        private static SpellsLevelEntry[] GetSpellLevelList()
        {
            return [/*00*/new SpellsLevelEntry {Count=[]},
                    /*01*/new SpellsLevelEntry {Count=[0,0]},
                    /*02*/new SpellsLevelEntry {Count=[0,1]},
                    /*03*/new SpellsLevelEntry {Count=[0,1]},
                    /*04*/new SpellsLevelEntry {Count=[0,1,0]},
                    /*05*/new SpellsLevelEntry {Count=[0,1,1]},
                    /*06*/new SpellsLevelEntry {Count=[0,2,1]},
                    /*07*/new SpellsLevelEntry {Count=[0,2,1,0]},
                    /*08*/new SpellsLevelEntry {Count=[0,2,1,1]},
                    /*09*/new SpellsLevelEntry {Count=[0,2,2,1]},
                    /*10*/new SpellsLevelEntry {Count=[0,3,2,1,0]},
                    /*11*/new SpellsLevelEntry {Count=[0,3,2,1,1]},
                    /*12*/new SpellsLevelEntry {Count=[0,3,2,2,1]},
                    /*13*/new SpellsLevelEntry {Count=[0,3,3,2,1]},
                    /*14*/new SpellsLevelEntry {Count=[0,4,3,2,1]},
                    /*15*/new SpellsLevelEntry {Count=[0,4,3,2,2]},
                    /*16*/new SpellsLevelEntry {Count=[0,4,3,3,2]},
                    /*17*/new SpellsLevelEntry {Count=[0,4,4,3,3]},
                    /*18*/new SpellsLevelEntry {Count=[0,4,4,3,3]},
                    /*19*/new SpellsLevelEntry {Count=[0,4,4,3,3]},
                    /*20*/new SpellsLevelEntry {Count=[0,4,4,3,3]},
                    /*21*/new SpellsLevelEntry {Count=[0,5,4,3,3,1]},
                    /*22*/new SpellsLevelEntry {Count=[0,5,4,3,3,2]},
                    /*23*/new SpellsLevelEntry {Count=[0,5,4,4,3,3]},
                    /*24*/new SpellsLevelEntry {Count=[0,5,4,4,3,3,1]},
                    /*25*/new SpellsLevelEntry {Count=[0,5,4,4,3,3,2]},
                    /*26*/new SpellsLevelEntry {Count=[0,6,5,4,3,3,3]},
                    /*27*/new SpellsLevelEntry {Count=[0,6,5,4,4,3,3]},
                    /*28*/new SpellsLevelEntry {Count=[0,6,5,4,4,3,3]},
                    /*29*/new SpellsLevelEntry {Count=[0,6,5,4,4,3,3]},
                    /*30*/new SpellsLevelEntry {Count=[0,6,5,4,4,4,3]},
                    /*31*/new SpellsLevelEntry {Count=[0,6,5,4,4,4,3]},
                    /*32*/new SpellsLevelEntry {Count=[0,6,5,4,4,4,3]},
                    /*33*/new SpellsLevelEntry {Count=[0,6,5,4,4,4,3]},
                    /*34*/new SpellsLevelEntry {Count=[0,6,5,4,4,4,3]},
                    /*35*/new SpellsLevelEntry {Count=[0,6,5,4,4,4,3]},
                    /*36*/new SpellsLevelEntry {Count=[0,6,5,4,4,4,3]},
                    /*37*/new SpellsLevelEntry {Count=[0,6,5,4,4,4,3]},
                    /*38*/new SpellsLevelEntry {Count=[0,6,5,4,4,4,3]},
                    /*39*/new SpellsLevelEntry {Count=[0,6,5,4,4,4,3]},
                    /*40*/new SpellsLevelEntry {Count=[0,6,5,4,4,4,3]}];
        }
        private static SpellLevelList[] GetSpellList()
        {
            var RangerSpells = SpellListRefs.RangerSpellList.Reference.Get();
            var DruidSpells = SpellListRefs.DruidSpellList.Reference.Get();
            SpellLevelList[] SpellsByLevel = RangerSpells.SpellsByLevel;
            SpellLevelList[] X = DruidSpells.SpellsByLevel;

            SpellsByLevel.SetValue(X.GetValue(5), 5);
            SpellsByLevel.SetValue(X.GetValue(6), 6);
            return SpellsByLevel;
        }
    }

}