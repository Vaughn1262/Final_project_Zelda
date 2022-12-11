using Raylib_cs;
using System.Numerics;
class Player: gameObject{
    int PlayerHeight = 25;
    int PlayerWidth = 25;
    

    public Player(Color Color1, int size){
        Size = size;
    }

    public void Playermove(ref Vector2 PlayerPosition){
        var PlayerMoveSpeed = 4;

        if (Raylib.IsKeyDown(KeyboardKey.KEY_DOWN)) {
            PlayerPosition.Y += PlayerMoveSpeed;
        }
        if (Raylib.IsKeyDown(KeyboardKey.KEY_UP)) {
            PlayerPosition.Y -= PlayerMoveSpeed;
        }

        if (Raylib.IsKeyDown(KeyboardKey.KEY_RIGHT)) {
            PlayerPosition.X += PlayerMoveSpeed;
        }

        if (Raylib.IsKeyDown(KeyboardKey.KEY_LEFT)) {
            PlayerPosition.X -= PlayerMoveSpeed;
        }

        Raylib.DrawRectangle((int)PlayerPosition.X, (int)PlayerPosition.Y, PlayerHeight, PlayerWidth, Color.BLUE); 
    } 

    public Rectangle Rect(ref Vector2 PlayerPosition) {
        return new Rectangle((float)PlayerPosition.X, (float)PlayerPosition.Y, PlayerHeight, PlayerWidth);
    }
}