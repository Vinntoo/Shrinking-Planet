using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour {

	void Update ()
	{
		if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved )
		{
			GameManager.instance.Restart();
		}

		GetComponent<RectTransform>().localScale = Vector3.one * Planet.Size;
	}

	public void Menu ()
	{
		SceneManager.LoadScene("Menu");
	}

}
