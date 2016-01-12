using UnityEngine;
using System.Collections;

public class MovingShooter : MonoBehaviour
{

    public GameObject projectile, gun;

    private GameObject projectileParent;
    


    void Start()
    {
       

        // Creates a parent if necessary
        projectileParent = GameObject.Find("Projectiles");
        if (!projectileParent)
        {
            projectileParent = new GameObject("Projectiles");
        }

         }

    void Update()
    {
    }
   

    private void Fire()
    {
        GameObject newProjectile = Instantiate(projectile) as GameObject;
        newProjectile.transform.parent = projectileParent.transform;
        newProjectile.transform.position = gun.transform.position;
    }
}
