using UnityEngine;

public class CamMove : MonoBehaviour
{
    [SerializeField] private Transform player;

    [Range(0f, 1f)]
    public float smoothTime;

    [SerializeField] private Vector3 offset = new Vector3(0, 0, -10f);

    private Vector3 velocity = Vector3.zero;

    void Awake()
    {
        transform.position = player.position;
    }

    private void LateUpdate()
    {
        if (player != null)
        {
            transform.position = Vector3.SmoothDamp(transform.position, player.position + offset, ref velocity, smoothTime);
        }
    }
}
