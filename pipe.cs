using Godot;
using System;

public partial class pipe : Sprite2D
{
	
	
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}
	
	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		
		float y_height_random = GD.RandRange(700,0);
		
		bool way_too_far_to_the_left = this.Position[0] <= 0;
		
		
		
		if (way_too_far_to_the_left){
			this.Position = new Vector2(2000,y_height_random);
		}
		
		this.Position += new Vector2(-140 * Convert.ToSingle(delta),0);
		
	}
}



