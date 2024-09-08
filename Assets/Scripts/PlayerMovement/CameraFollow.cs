using DG.Tweening;
using UnityEngine;

namespace Scenes.Level4.Scripts.PlayerMovement
{
    public class CameraFollow : MonoBehaviour
    {
        public Transform toFollow;

        // Update is called once per frame
        public void Update()
        {
            if (GameManager.Instance.tiempo.currentTime > 0.1f)
            {
                transform.DOMove(toFollow.position, 0.1f);
            }
        }
    }

}

