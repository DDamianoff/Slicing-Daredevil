using System;
using System.Diagnostics.CodeAnalysis;
using Godot;

namespace SlicingDaredevil;

[SuppressMessage("ReSharper", "UnusedType.Global")]
public class Yo : KinematicBody2D
{
	private const int Speed = 40;


	public override void _PhysicsProcess(float delta)
	{
		var direction = Vector2.Zero;

		if (Input.IsActionPressed(Ui.Up))
			direction.y--;

		if (Input.IsActionPressed("ui_down"))
			direction.y++;

		if (Input.IsActionPressed("ui_left")) 
			direction.x--;
	
		if (Input.IsActionPressed("ui_right")) 
			direction.x++;

		MoveAndSlide(Speed * direction);
	
		base._PhysicsProcess(delta);
	
		Console.Write(Speed);
	}
}

