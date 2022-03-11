using System;

namespace Task01
{
    class Weapon
    {
        private readonly int _damage;
        private readonly int _bulletPerShot;
        private int _bullets;

        public Weapon(int damage, int bullet, int bulletPerShot)
        {
            if(damage <= 0)
                throw new InvalidOperationException(nameof(damage));
            if(bullet < 0)
                throw new InvalidOperationException(nameof(bullet));
            if(bulletPerShot <= 0)
                throw new InvalidOperationException(nameof(bulletPerShot));

            _damage = damage;
            _bullets = bullet;
            _bulletPerShot = bulletPerShot;
        }

        public void Fire(Player target)
        {
            if(target == null)
                throw new ArgumentNullException(nameof(target));

            if(CanFire())
                target.TakeDamage(_damage);

            _bullets -= _bulletPerShot;
        }

        private bool CanFire()
        {
            if (_bullets <= 0)
                return false;
            else if (_bullets < _bulletPerShot)
                return false;
            return true;
        }
    }

    class Player
    {
        private int _health;

        public Player(int health)
        {
            if (health <= 0)
                throw new InvalidOperationException(nameof(health));

            _health = health;
        }

        private bool _isAlive => _health > 0;

        public void TakeDamage(int damage)
        {
            if(damage < 0)
                throw new ArgumentOutOfRangeException(nameof(damage));

            if (_isAlive == false)
                return;

            _health -= damage;
        }
    }

    class Bot
    {
        private readonly Weapon _weapon;

        public Bot(Weapon weapon)
        {
            if(weapon == null)
                throw new ArgumentNullException(nameof(weapon));

            _weapon = weapon;
        }

        public void OnSeePlayer(Player target)
        {
            if(target == null)
                throw new ArgumentNullException(nameof(target));

            _weapon.Fire(target);
        }
    }
}
