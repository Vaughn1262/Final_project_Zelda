using Raylib_cs;
using System.Numerics;

class gameObject{
    public Vector2 position{ get; set; } = new Vector2(0,0);
    public Vector2 speed{get; set;} = new Vector2(0,0);
    public Color color{get; set;}
    public int Size{ get; set;}
    

    public gameObject(){
    }

    virtual public void Draw() {
        Raylib.DrawRectangle((int)position.X, (int)position.Y,Size, Size, color);
    }

    public void Move(){
        Vector2 NewPosition = this.position;
        NewPosition.X += speed.X;
        NewPosition.Y += speed.Y;
        position = NewPosition;
    }

    public Rectangle Rect() {
        return new Rectangle((float)position.X, (float)position.Y, 20, 20);
    }
}