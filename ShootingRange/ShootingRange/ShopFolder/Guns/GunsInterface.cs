using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShootingRange.Shop.Guns
{
    internal interface GunsInterface
    {
        void Information();
        void RenameGun();
        void StausEditionAmmunition();
        void StatusPrizeForOneShot();
        void EditionAmmunitionOrder(int change);
    }
}
