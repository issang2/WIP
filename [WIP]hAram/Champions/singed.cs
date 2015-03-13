﻿using LeagueSharp;
using LeagueSharp.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hAram.Champions
{
    class singed : Base
    {

        public singed()
        {
            Game.PrintChat("hAram : " + Player.ChampionName + "Loaded.");
        }

        public override void Game_OnUpdate(EventArgs args)
        {
            base.Game_OnUpdate(args);

            

            CastSpell(Q, qData);
            CastSpell(W, wData);
            CastSpell(E, eData);

            if ((status == "Fight" && Player.HealthPercentage() <= 50))
            {
                CastSpell(R, rData);
            }
        }
    }
}
