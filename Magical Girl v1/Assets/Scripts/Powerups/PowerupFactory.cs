using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Powerups
{
    class PowerupFactory
    {

        public static Powerup Create(Enums.MQType MQType)
        {
            switch(MQType)
            {
                case Enums.MQType.SUPERPOSITION_PARTICLE:
                    return new StrengthPowerup();
            }

            return null;
        }

    }
}
