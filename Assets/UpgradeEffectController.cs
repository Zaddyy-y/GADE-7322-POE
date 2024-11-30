using UnityEngine;

public class UpgradeEffectController : MonoBehaviour
{
    public ParticleSystem upgradeEffect;

    public void PlayUpgradeEffect()
    {
        if (upgradeEffect != null)
        {
            upgradeEffect.Play();
        }
    }
}
