using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_characters
{
    public class WeaponAttributes
    {
        #region Variables
        private int damage;
        private double attackSpeed;
        #endregion

        #region Properties
        public int Damage { get => damage; set => damage = value; }
        public double AttackSpeed { get => attackSpeed; set => attackSpeed = value; }
    
        #endregion

        #region Constructors

        public WeaponAttributes()
        {
        damage = 1;
        attackSpeed = 1.0;
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
