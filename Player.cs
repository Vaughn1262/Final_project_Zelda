using Raylib_cs;
using System.Numerics;
class Player: gameObject{
    int PlayerHeight = 25;
    int PlayerWidth = 25;

    float PlayerMoveSpeed = 4;
    

    public Player(Color Color1, int size){
        Size = size;
    }

    public void Playermove(ref Vector2 PlayerPosition){
        if (PlayerPosition.X > 0 & PlayerPosition.Y > 0 & PlayerPosition.X < 1000 & PlayerPosition.Y < 1000){
            PlayerMoveSpeed = 4;
        }

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

        if (PlayerPosition.X <= 0){
            PlayerMoveSpeed = 0;
            PlayerPosition.X += 1;
            
        }
        if (PlayerPosition.Y <= 0){
            PlayerMoveSpeed = 0;
            PlayerPosition.Y += 1;
            
        }
        if (PlayerPosition.X >= 1000){
            PlayerMoveSpeed = 0;
            PlayerPosition.X -= 1;
            
        }
        if (PlayerPosition.Y >= 1000){
            PlayerMoveSpeed = 0;
            PlayerPosition.Y -= 1;
            
        }
        


        Raylib.DrawRectangle((int)PlayerPosition.X, (int)PlayerPosition.Y, PlayerHeight, PlayerWidth, Color.BLUE); 
    } 

    public Rectangle Rect(ref Vector2 PlayerPosition) {
        return new Rectangle((float)PlayerPosition.X, (float)PlayerPosition.Y, PlayerHeight, PlayerWidth);
    }
}