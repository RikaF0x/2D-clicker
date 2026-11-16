using UnityEngine;


public class CursorParticle : MonoBehaviour
{
    [SerializeField] private Camera cam;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (TryGetComponent(out ParticleSystem cursorParticleSystem))
        {
            cursorParticleSystem.Play();
        }
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 curPose =  Input.mousePosition;
        Vector3 worldPos = cam.ScreenToWorldPoint(curPose);
        worldPos.z = 0;
        transform.position = worldPos;
    }
}
