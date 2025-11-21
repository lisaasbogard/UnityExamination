using UnityEngine;
using UnityEngine.SceneManagement;

public class Changescene : MonoBehaviour
{
 public void GoToStartScene()
 {
  SceneManager.LoadScene("SampleScene");
 }

}
