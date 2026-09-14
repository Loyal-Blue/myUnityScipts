using UnityEngine;

public class projectileShooting : MonoBehaviour
{
    [SerializeField] 
    private GameObject projectileType;
    public float projectileSpeed = 10f;
    public float projectileDamage = 5f;
    public float projectileReloadSpeed = 9f;
    


    public void Update() //Updates once per frame
    {
        tankProjectileShoot();
    }

    public void tankProjectileShoot()
    {
        
    }
}