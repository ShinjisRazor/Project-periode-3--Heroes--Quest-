using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{

    private void OnTriggerEnter(Collider infoAboutWhatIHit)
    {
        infoAboutWhatIHit.gameObject.GetComponent<EnemyLife>().Damage();
    }
}
