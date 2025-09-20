using JetBrains.Annotations;
using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    [SerializeField] private int life = 100;
    [SerializeField] private float probabilidad;

    void Start()
    {
        probabilidad = Random.Range(5,10);
        GetDamage(Random.Range(70,80), true || false);
    }
    void Update()
    {
        RecieveDamage();
    }
    public void RecieveDamage()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GetDamage(20);
        }

    }
    public void GetDamage(int damagecritical, bool knocback = true || false)
    {
        damagecritical = Random.Range(70, 90);
        if (probabilidad >= 7)
        {
            life -= damagecritical;
            Debug.Log("El Heroe le dieron daño_" + damagecritical + "_mas knocback_" + knocback);
            knocback = true;
            life -= 20;
            Death();
        }
        else
        {

            life -= damagecritical;
            Debug.Log("El Heroe solo recibio un daño critico_" + damagecritical + "_!!");
            knocback = false;
        }
    }
    public void Death()
    {
        if (life < 0)
        {
            Destroy(gameObject);
        }
    }

}

