
using UnityEngine;
using UnityEngine.UI;
public class Texti : MonoBehaviour {

	public Transform player;
	public Text stig;
	// Update is called once per frame
	void Update () {
		stig.text=player.position.z.ToString("0");
	}
}
