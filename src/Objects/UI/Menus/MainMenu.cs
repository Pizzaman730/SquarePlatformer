using System;
using Microsoft.Xna.Framework;

namespace SquarePlatformer
{
    public class UIMainMenu : IMenu
    {
        private StartButton startButton;
        private EditorButton editorButton; 

        public UIMainMenu()
        {
        }

        public void Show()
        {
            // Show buttons and UI
            new Ground(new Vec2(0, 0), new Vec2(4000, 2000));

            startButton = new StartButton(new Vec2()); 
            UIManager.AddObject(startButton);

            // editorButton = new EditorButton(new Vec2(100, 0));
            // UIManager.AddObject(editorButton);

            Camera.center = startButton.position;
        }

        public void Hide()
        {
            UIManager.RemoveObject(startButton);
            // UIManager.RemoveObject(editorButton); 
        }

        public void Update()
        {

        }
    }
}