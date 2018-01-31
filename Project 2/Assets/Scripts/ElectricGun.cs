using UnityEngine;

public class ElectricGun : MonoBehaviour
{
    public float damage = 10f;
    public float range = 100f;
    public float impactForce = 10f;
    public float fireReet = 15f;

    public Camera fpsCam;
    public ParticleSystem electricBall;
    public GameObject impactEffect;

    private float nextFire = 0f;

	void Update ()
    {
		if (Input.GetButton("Fire1") && Time.time >= nextFire)
        {
            nextFire = Time.time + 1f / fireReet;
            Shoot();
        }
	}

    void Shoot()
    {
        electricBall.Play();

        RaycastHit hit;
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);

            Enemy enemy = hit.transform.GetComponent<Enemy>();
            if (enemy != null)
            {
                enemy.TakeDamage(damage);
            }

            if (hit.rigidbody != null)
            {
                hit.rigidbody.AddForce(-hit.normal * impactForce);
            }

            GameObject impactGO = Instantiate(impactEffect, hit.point, Quaternion.LookRotation(hit.normal));
            Destroy(impactGO, 2f);
        }

    }
}
