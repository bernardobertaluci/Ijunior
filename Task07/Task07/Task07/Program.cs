class Weapon
{
    private readonly int _bulletsPerShot;
    private int _bullets;
    private int _bulletAfterShot => _bullets - _bulletsPerShot;

    public Weapon(int bulletsPerShot, int bullets)
    {
        _bulletsPerShot = bulletsPerShot;
        _bullets = bullets;
    }

    public bool CanShoot => _bulletAfterShot > 0;

    public void Shoot()
    {
        if(CanShoot)
            _bullets = _bulletAfterShot;
    }  
}