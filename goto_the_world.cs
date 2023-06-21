using Godot;
using System;

public partial class goto_the_world : Node
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
			var flappy_world = (PackedScene)ResourceLoader.Load("res://the_world.tscn");
		GetTree().ChangeSceneToPacked(flappy_world);
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}
