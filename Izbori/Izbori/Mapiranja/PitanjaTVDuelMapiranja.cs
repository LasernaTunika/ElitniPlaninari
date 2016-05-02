﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Izbori.Entiteti;
using FluentNHibernate.Mapping;

namespace Izbori.Mapiranja
{
    class PitanjaTVDuelMapiranja : SubclassMap<PitanjaTVDuel>
    {
        public PitanjaTVDuelMapiranja()
        {
            Table("PitanjaTVDuel");

            Map(x => x.IDDuela).Column("IDDuela");
            Map(x => x.Tekst).Column("Tekst");
        }
    }
}
