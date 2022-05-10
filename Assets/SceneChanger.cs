using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
	public void ChangeScene(string sceneName)
	{
		Debug.Log("Loading scne " + sceneName);
		//SceneManager.LoadScene(name);
		SceneManager.LoadScene(int.Parse(sceneName));
	}
	public void Exit()
	{
		Application.Quit();
	}
}