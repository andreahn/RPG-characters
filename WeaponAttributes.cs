using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_characters
{
    class WeaponAttributes
    {
        #region Variables
        private int damage = 1;
        private double attackSpeed = 1.0;
        #endregion

        #region Properties
        public int Damage { get => damage; }
        public double AttackSpeed { get => attackSpeed; }
        #endregion

        #region Constructors

        public WeaponAttributes()
        {

        }

        public WeaponAttributes(int damage)
        {
            this.damage = damage;
        }

        public WeaponAttributes(double speed)
        {
            attackSpeed = speed;
        }

        public WeaponAttributes(int damage, double speed)
        {
            this.damage = damage;
            attackSpeed = speed;
        }
        #endregion
    }
}
