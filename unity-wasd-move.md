1. Select 2D Core for a new project
2. Create "Game Object -> 2D Object -> Sprites -> Triangle". The default position will be X:0 Y:0 Z:0
3. Change game object to be red
4. Press "Play". You should see a red triangle in the middle of the screen
5. Select "Triangle" object in the object hierarchy, "Add Component", select "New Script" and name it "MoveTriangle", click "Create and Add"
6. Double click "Move" in Assets to open in Visual Studio Code
7. Add the following code in "Start" function: `Debug.Log("Starting: " + gameObject.name);`
8. Add movement code from <https://github.com/t4guw/100-Unity-Mechanics-for-Programmers/tree/master/programs/wasd_movement_2d> under Update
9. Run your project to confirm that WASD keys work for movement. Modify the `Speed` variable to modify object speed.
10. Add a new object, Square, set the location to be `X:0 Y:1`, color to be green and add a new script MoveSquare
11. Add new component, `Rigidbody 2D`, set its `Gravity Scale` to 0 and the code from `Speed_Direction_Friction ` <https://github.com/t4guw/100-Unity-Mechanics-for-Programmers/tree/master/programs/wasd_speed_direction_2d> to the script.
12. Set `Speed: 0.1, Rotate Speed 0.01, Linear Drag: 1` and run the project.
13. Play with different friction and speed variables
14. Add `Game Object -> UI -> Text`. It will create a Canvas as parent and a `Text (TMP)` as child object. Change the text to `Scene 1`. The text in Canvas is in the Canvas screen coordinates which is different than the World coordinates.
15. Run your project to see that the text is placed correctly.
16. Select `Main Camera` and press `Shift F` to focus the scene on main camera
17. Create a new Scene via `File -> New Scene`, name it Scene2, create a `UI -> Text` with text `Scene 2`. Run the scene to make sure it looks different to the original scene created.
18. Add the new scene to the `File -> Build Settings`
19. Select the original `SampleScene` and create a new empty game object, name it `GameController` attach a new script to it.
20. Put the following code in the GameController script

```using UnityEngine.SceneManagement;

    void Update()
    {
        if (Input.GetKey(KeyCode.N)) {
                SceneManager.LoadScene("Scene2");
        }
    }
```

21. Run `SampleScene` to confirm that switching to `Scene2` works as intended.
22. Since we do not want the `GameController` to be destroyed when switching to a new scene, add the following code to its script 

`public static Controller Instance;

    private void Awake()
    {
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }`

23. Experiment with `SceneManager.sceneCountInBuildSettings` to switch to a random scene.
24. We eventually need to exit our game, so add the following code to `GameController` script

```
        if (Input.GetKey(KeyCode.Escape)) {
            #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
            #endif
            Application.Quit();
        }
```
