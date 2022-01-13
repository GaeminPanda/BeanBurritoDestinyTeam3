using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public float fireRate = 0.2f;
    public Transform firingpoint;
    public GameObject BeanBulletPrefab;

    float timeUntilFire;
    Movement pm;

    private void Start()
    {
        pm = gameObject.GetComponent<Movement>();
    }
    private void Update()
    {
        if(Input.GetMouseButton(0) && timeUntilFire < Time.time)
        {
            Shoot();
            timeUntilFire = Time.time + fireRate;
        }
    }
    void Shoot()
    {
        float angle = pm.isFacingRight ? 0f : 180f;
        Instantiate(BeanBulletPrefab, firingpoint.position, Quaternion.Euler(new Vector3(0f, 0f, angle)));
    }
}
