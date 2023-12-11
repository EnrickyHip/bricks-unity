
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public static class GameManager
{ 
	private static int level = 1;
	private static readonly int finalLevel = 5;
	public static int Level { get => level; }
    public static int BricksRemain 
	{ 
		get => GameObject.FindGameObjectsWithTag("Brick").Length; 
	}

    public static void Replay()
	{
        LoadLevel(level);
    }

	public static void NextLevel()
	{
		if (level == finalLevel)
		{
            SceneManager.LoadScene("final");
			return;
		}

        level++;
		LoadLevel(level);
    }

    private static void LoadLevel(int level)
	{
        SceneManager.LoadScene("level" + level.ToString());
    }
}
