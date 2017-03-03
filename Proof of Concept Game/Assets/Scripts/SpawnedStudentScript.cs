using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnedStudentScript : MonoBehaviour {

    private Rigidbody2D rb;
    public float speed;

    public bool inFightScene;
    private FightSceneManager fightSceneManager;
    public int damage = 50;
    private float timeUntilActionable;
    public float hitstunFactor;
    public float knockbackDamageGrowthFactor;
    private bool inHitstun;

    protected float baseKnockback;
    protected float knockbackGrowth;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        timeUntilActionable = 0;
        inHitstun = false;

        if (inFightScene)
        {
            fightSceneManager = GameObject.FindWithTag("FightSceneManager").GetComponent<FightSceneManager>();
        }
    }

    protected virtual void HitPlayer(GameObject player)
    {
        player.GetComponent<PlayerController>().TakeHit(damage, baseKnockback, knockbackGrowth, GetDirectionHit(player));

    }

    protected virtual Vector3 GetDirectionHit(GameObject playerHit)
    {
        return Vector3.zero;
    }

    void OnTriggerStay2D(Collider2D collider)
    {
        GameObject collidedObject = collider.gameObject;
        if (collidedObject.tag == "OtherStudent")
        {
            PlayerController pc = collidedObject.GetComponent<PlayerController>();
            HitPlayer(collidedObject);
        }
    }



    public void TakeHit(int damageTaken, float baseKnockback, float knockbackGrowth, Vector3 knockbackVector)
    {
        damage += damageTaken;
        float knockbackMagnitude = baseKnockback + (knockbackGrowth * damage * knockbackDamageGrowthFactor);
        Stun(knockbackMagnitude * hitstunFactor);
        rb.velocity = knockbackMagnitude * knockbackVector;

    }

    public void Stun(float hitstun)
    {
        timeUntilActionable = hitstun;
        inHitstun = true;
        rb.velocity = Vector3.zero;
        GetComponent<SpriteRenderer>().color = Color.red;
    }
}
