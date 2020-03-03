using UnityEngine;

public class BombCreation : MonoBehaviour {
    public GameObject player;
    public GameObject bomb;
    Vector3 placement;
    void Update() {
        if (Input.GetKeyDown("space")) {
            if (Mathf.Abs(player.transform.position.x) - Mathf.Abs((int)player.transform.position.x) > .5) {
                if (player.transform.position.x < 0) {
                    placement[0] = (int)(player.transform.position.x - .5);
                }
                else {
                    placement[0] = (int)(player.transform.position.x + .5);
                }
            } else {
                placement[0] = (int)(player.transform.position.x);
            }
            if (Mathf.Abs(player.transform.position.y) - Mathf.Abs((int)player.transform.position.y) > .5) {
                if (player.transform.position.y < 0) {
                    placement[1] = (int)(player.transform.position.y - .5);
                } else {
                    placement[1] = (int)(player.transform.position.y + .5);
                }
            } else {
                placement[1] = (int)(player.transform.position.y);
            }
            placement[2] = 0;
            Instantiate(bomb, placement, Quaternion.identity);
        }
    }
}
