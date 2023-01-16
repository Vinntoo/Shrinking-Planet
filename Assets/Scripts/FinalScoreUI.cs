using UnityEngine.UI;
using UnityEngine;
using TMPro;

[RequireComponent(typeof(Text))]
public class FinalScoreUI : MonoBehaviour {

	void Start ()
	{
		GetComponent<TextMeshProUGUI>().text = "d = <i><b>" + Planet.Score.ToString("0.#") + "</b>m</i>";
	}

}
