using Godot;
using System;

public partial class counter : RichTextLabel
{
	
	Int32 count = 0;
	
	private void _on_area_2d_area_entered(Area2D area){
		count += 1;
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		this.Text = count.ToString();
	}
}



