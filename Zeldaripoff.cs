using Raylib_cs;
using System.Numerics;


class ZeldaRipoff{
    public void Play(){
        Screen screen = new Screen(1000, 1000);
        bool gameover = false;
        var Random = new Random();
        var PlayerPosition = new Vector2(screen.ScreenHeight / 2, screen.ScreenWidth / 2); 
        var Position = new Vector2(Random.Next(screen.ScreenWidth), Random.Next(screen.ScreenHeight));
        Player player = new Player(Color.BLUE, 25);
        player.position = PlayerPosition;
        var Objects = new List<gameObject>();
        Enemy enemy1 = new Enemy(Color.RED, 25);
        enemy1.position = new Vector2(Random.Next(screen.ScreenWidth), Random.Next(screen.ScreenHeight));
        Objects.Add(enemy1);
        Enemy enemy2 = new Enemy(Color.RED, 25);
        enemy2.position = new Vector2(Random.Next(screen.ScreenWidth), Random.Next(screen.ScreenHeight));
        Objects.Add(enemy2);
        Potion potion = new Potion(Color.PURPLE, 25);
        potion.position = new Vector2(Random.Next(screen.ScreenWidth), Random.Next(screen.ScreenHeight));
        Objects.Add(potion);
        Key key = new Key(Color.GOLD, 25);
        key.position = new Vector2(Random.Next(screen.ScreenWidth), Random.Next(screen.ScreenHeight));
        Objects.Add(key);
       
        playerHealth health = new playerHealth();
        health.GetStartingHealth();
            
        Raylib.InitWindow(screen.ScreenHeight, screen.ScreenWidth, "ZeldaRipoff");
        Raylib.SetTargetFPS(60);

        while (!Raylib.WindowShouldClose())
        {   
            while (!gameover){
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.GREEN);
                health.Draw();
                foreach (var obj in Objects){
                    obj.Draw();
                }

                player.Playermove(ref PlayerPosition);
                for (int i = 0; i < Objects.Count(); i++)
                    if (Raylib.CheckCollisionRecs(Objects[i].Rect(), player.Rect(ref PlayerPosition))){
                        
                        if (Objects[i].Equals(potion)){
                            health.Heal();
                        }
                        else if (Objects[i].Equals(enemy1)){
                            health.Damage();
                            if (health.currenthealth <= 0){
                                
                           
                                health.Draw();
                                Raylib.DrawText($"You Lose", 80, 40, 20, Color.BLUE);
                                gameover = true;
                                
                            }
                        }
                        else if (Objects[i].Equals(enemy2)){
                            health.Damage();
                            if (health.currenthealth <= 0){
                                
                               
                                health.Draw();
                                Raylib.DrawText($"You Lose", 80, 40, 20, Color.BLUE);
                                gameover = true;
                            }
                        }
                        else if (Objects[i].Equals(key)){
                            gameover = true;
                            Raylib.DrawText($"You win", 80, 40, 20, Color.BLUE);
                        }
                        Objects.Remove(Objects[i]);
                    }


            Raylib.EndDrawing();
            }
            Raylib.BeginDrawing();
            Raylib.ClearBackground(Color.GREEN);
            health.Draw();
            if (health.currenthealth <= 0){
                Raylib.DrawText($"You Lose", 80, 40, 20, Color.BLUE);
            }
            else{
                Raylib.DrawText($"You win", 80, 40, 20, Color.BLUE);
            }
            foreach (var obj in Objects){
                    obj.Draw();
            }
            player.Playermove(ref PlayerPosition);
            Raylib.EndDrawing();

        }

        Raylib.CloseWindow();
    }
}
