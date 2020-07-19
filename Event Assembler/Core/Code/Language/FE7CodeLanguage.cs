﻿// Decompiled with JetBrains decompiler
// Type: Nintenlord.Event_Assembler.Core.Code.Language.FE7CodeLanguage
// Assembly: Core, Version=9.10.4713.28131, Culture=neutral, PublicKeyToken=null
// MVID: 65F61606-8B59-4B2D-B4B2-32AA8025E687
// Assembly location: E:\crazycolorz5\Dropbox\Unified FE Hacking\ToolBox\EA V9.12.1\Core.exe

using System;
using System.Collections.Generic;

namespace Nintenlord.Event_Assembler.Core.Code.Language
{
    public static class FE7CodeLanguage
    {
        public static readonly string Name = "FE7";

        public static readonly Tuple<string, List<Priority>>[][] PointerList = new Tuple<string, List<Priority>>[8][]
        {
            new Tuple<string, List<Priority>>[1]{ new Tuple<string, List<Priority>>("TurnBasedEvents", EACodeLanguage.MainPriorities) },
            new Tuple<string, List<Priority>>[1]{ new Tuple<string, List<Priority>>("CharacterBasedEvents", EACodeLanguage.MainPriorities) },
            new Tuple<string, List<Priority>>[1]{ new Tuple<string, List<Priority>>("LocationBasedEvents", EACodeLanguage.MainPriorities) },
            new Tuple<string, List<Priority>>[1]{ new Tuple<string, List<Priority>>("MiscBasedEvents", EACodeLanguage.MainPriorities) },
            new Tuple<string, List<Priority>>[2]{ new Tuple<string, List<Priority>>("TrapsEliwoodMode", EACodeLanguage.TrapPriorities), new Tuple<string, List<Priority>>("TrapsHectorMode", EACodeLanguage.TrapPriorities) },
            new Tuple<string, List<Priority>>[4]{ new Tuple<string, List<Priority>>("EnemyUnitsENM", EACodeLanguage.UnitPriorities), new Tuple<string, List<Priority>>("EnemyUnitsEHM", EACodeLanguage.UnitPriorities), new Tuple<string, List<Priority>>("EnemyUnitsHNM", EACodeLanguage.UnitPriorities), new Tuple<string, List<Priority>>("EnemyUnitsHHM", EACodeLanguage.UnitPriorities) },
            new Tuple<string, List<Priority>>[4]{ new Tuple<string, List<Priority>>("AllyUnitsENM", EACodeLanguage.UnitPriorities), new Tuple<string, List<Priority>>("AllyUnitsEHM", EACodeLanguage.UnitPriorities), new Tuple<string, List<Priority>>("AllyUnitsHNM", EACodeLanguage.UnitPriorities), new Tuple<string, List<Priority>>("AllyUnitsHHM", EACodeLanguage.UnitPriorities) },
            new Tuple<string, List<Priority>>[2]{ new Tuple<string, List<Priority>>("BeginningScene", EACodeLanguage.NormalPriorities), new Tuple<string, List<Priority>>("EndingScene", EACodeLanguage.NormalPriorities) }
        };

        private static readonly Tuple<string, List<Priority>>[][] TutorialPointerList = new Tuple<string, List<Priority>>[12][]
        {
            new Tuple<string, List<Priority>>[4]{ new Tuple<string, List<Priority>>("PrologueTutorial1", EACodeLanguage.MainPriorities), new Tuple<string, List<Priority>>("PrologueTutorial2", EACodeLanguage.MainPriorities), new Tuple<string, List<Priority>>("PrologueTutorial3", EACodeLanguage.MainPriorities), new Tuple<string, List<Priority>>("PrologueTutorial4", EACodeLanguage.MainPriorities) },
            new Tuple<string, List<Priority>>[4]{ new Tuple<string, List<Priority>>("Ch1Tutorial1", EACodeLanguage.MainPriorities), new Tuple<string, List<Priority>>("Ch1Tutorial2", EACodeLanguage.MainPriorities), new Tuple<string, List<Priority>>("Ch1Tutorial3", EACodeLanguage.MainPriorities), new Tuple<string, List<Priority>>("Ch1Tutorial4", EACodeLanguage.MainPriorities) },
            new Tuple<string, List<Priority>>[4]{ new Tuple<string, List<Priority>>("Ch2Tutorial1", EACodeLanguage.MainPriorities), new Tuple<string, List<Priority>>("Ch2Tutorial2", EACodeLanguage.MainPriorities), new Tuple<string, List<Priority>>("Ch2Tutorial3", EACodeLanguage.MainPriorities), new Tuple<string, List<Priority>>("Ch2Tutorial4", EACodeLanguage.MainPriorities) },
            new Tuple<string, List<Priority>>[4]{ new Tuple<string, List<Priority>>("Ch3Tutorial1", EACodeLanguage.MainPriorities), new Tuple<string, List<Priority>>("Ch3Tutorial2", EACodeLanguage.MainPriorities), new Tuple<string, List<Priority>>("Ch3Tutorial3", EACodeLanguage.MainPriorities), new Tuple<string, List<Priority>>("Ch3Tutorial4", EACodeLanguage.MainPriorities) },
            new Tuple<string, List<Priority>>[4]{ new Tuple<string, List<Priority>>("Ch4Tutorial1", EACodeLanguage.MainPriorities), new Tuple<string, List<Priority>>("Ch4Tutorial2", EACodeLanguage.MainPriorities), new Tuple<string, List<Priority>>("Ch4Tutorial3", EACodeLanguage.MainPriorities), new Tuple<string, List<Priority>>("Ch4Tutorial4", EACodeLanguage.MainPriorities) },
            new Tuple<string, List<Priority>>[4]{ new Tuple<string, List<Priority>>("Ch5Tutorial1", EACodeLanguage.MainPriorities), new Tuple<string, List<Priority>>("Ch5Tutorial2", EACodeLanguage.MainPriorities), new Tuple<string, List<Priority>>("Ch5Tutorial3", EACodeLanguage.MainPriorities), new Tuple<string, List<Priority>>("Ch5Tutorial4", EACodeLanguage.MainPriorities) },
            new Tuple<string, List<Priority>>[4]{ new Tuple<string, List<Priority>>("Ch6Tutorial1", EACodeLanguage.MainPriorities), new Tuple<string, List<Priority>>("Ch6Tutorial2", EACodeLanguage.MainPriorities), new Tuple<string, List<Priority>>("Ch6Tutorial3", EACodeLanguage.MainPriorities), new Tuple<string, List<Priority>>("Ch6Tutorial4", EACodeLanguage.MainPriorities) },
            new Tuple<string, List<Priority>>[4]{ new Tuple<string, List<Priority>>("Ch7Tutorial1", EACodeLanguage.MainPriorities), new Tuple<string, List<Priority>>("Ch7Tutorial2", EACodeLanguage.MainPriorities), new Tuple<string, List<Priority>>("Ch7Tutorial3", EACodeLanguage.MainPriorities), new Tuple<string, List<Priority>>("Ch7Tutorial4", EACodeLanguage.MainPriorities) },
            new Tuple<string, List<Priority>>[4]{ new Tuple<string, List<Priority>>("Ch7xTutorial1", EACodeLanguage.MainPriorities), new Tuple<string, List<Priority>>("Ch7xTutorial2", EACodeLanguage.MainPriorities), new Tuple<string, List<Priority>>("Ch7xTutorial3", EACodeLanguage.MainPriorities), new Tuple<string, List<Priority>>("Ch7xTutorial4", EACodeLanguage.MainPriorities) },
            new Tuple<string, List<Priority>>[4]{ new Tuple<string, List<Priority>>("Ch8Tutorial1", EACodeLanguage.MainPriorities), new Tuple<string, List<Priority>>("Ch8Tutorial2", EACodeLanguage.MainPriorities), new Tuple<string, List<Priority>>("Ch8Tutorial3", EACodeLanguage.MainPriorities), new Tuple<string, List<Priority>>("Ch8Tutorial4", EACodeLanguage.MainPriorities) },
            new Tuple<string, List<Priority>>[4]{ new Tuple<string, List<Priority>>("Ch9Tutorial1", EACodeLanguage.MainPriorities), new Tuple<string, List<Priority>>("Ch9Tutorial2", EACodeLanguage.MainPriorities), new Tuple<string, List<Priority>>("Ch9Tutorial3", EACodeLanguage.MainPriorities), new Tuple<string, List<Priority>>("Ch9Tutorial4", EACodeLanguage.MainPriorities) },
            new Tuple<string, List<Priority>>[4]{ new Tuple<string, List<Priority>>("Ch10Tutorial1", EACodeLanguage.MainPriorities), new Tuple<string, List<Priority>>("Ch10Tutorial2", EACodeLanguage.MainPriorities), new Tuple<string, List<Priority>>("Ch10Tutorial3", EACodeLanguage.MainPriorities), new Tuple<string, List<Priority>>("Ch10Tutorial4", EACodeLanguage.MainPriorities) }
        };
    }
}
