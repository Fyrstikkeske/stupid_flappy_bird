using Godot;
using System;



public partial class player : Sprite2D
{
	
	const float gravity = 8f;
	Vector2 velocity = new Vector2(0,0);
	bool jump_pressed = false;
	
	
	
	//perhaps there is some better way.
	private void _on_restart_button_button_down()
	{
		GetTree().Paused = false;
		var temp_world = (PackedScene)ResourceLoader.Load("res://goto_the_world.tscn");
		GetTree().ChangeSceneToPacked(temp_world);
	}
	
	private void _on_area_2d_area_entered(Area2D area){
		GetTree().Paused = true;
		Godot.Button restart_button = this.GetNode<Godot.Button>("restart_button");
		//it seems like these numbers were perfect for in the middle
		restart_button.GlobalPosition = new Vector2(1000, 525);
		restart_button.Visible = true;
		restart_button.Disabled = false;
		
	}
	
	
	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		Godot.AudioStreamPlayer jump_sound = this.GetNode<Godot.AudioStreamPlayer>("AudioStreamPlayer");
		velocity += new Vector2(0, gravity);
		
		if (Input.IsKeyPressed(Key.Space)){
			
			bool toohigh = this.Position[1] <= 0;
			
			if  (!toohigh) {
				if (jump_pressed == false){
					velocity = new Vector2(0, -400);
					jump_pressed = true;
					jump_sound.Playing = true;
				}
			}
		}
		else{
			jump_pressed = false;
		}
		
		bool toolow = this.Position[1] >= 1050;
		bool movingup = velocity[1] <= 0;
		
		if (toolow && !movingup){
			velocity = new Vector2(0,0);
		}
		
		
		this.Position += new Vector2(velocity[0] * Convert.ToSingle(delta), velocity[1] * Convert.ToSingle(delta));
		
		
		
		
	}
}
