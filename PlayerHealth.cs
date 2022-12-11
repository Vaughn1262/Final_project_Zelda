using Raylib_cs;
using System.Numerics;
class playerHealth: gameObject{

    private int startinghealth = 10;
    public int currenthealth = 0;

    public playerHealth(){

    }

    public int GetStartingHealth(){
        currenthealth = startinghealth;
        return currenthealth;
    }

    public int Heal(){
        currenthealth += 5;
        return currenthealth;
    }

    public int Damage(){
        currenthealth -= 5;
        return currenthealth;
    }
    public override void Draw(){
        Raylib.DrawText($"Health: {currenthealth}", 80, 10, 20, Color.BLUE);
    }
}
