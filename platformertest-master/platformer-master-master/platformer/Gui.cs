using System;
using SFML.System;
using SFML.Window;
using SFML.Graphics;

namespace platformer
{
    public class Gui
    {
        public Text gui;
        public int coins;
        public Gui(){
            gui = new Text();
            gui.CharacterSize = 10;
            gui.Font = new Font("assets/future.ttf");
            gui.Color = Color.Black;
        }
        public void reder(RenderTarget target){
            gui.DisplayedString = $"{coins}";
            gui.Position = new Vector2f(50, 50);
            target.Draw(gui);
        }
        public void checkCoins(Scene scene){
            coins = scene.coins;
        }
    }
}