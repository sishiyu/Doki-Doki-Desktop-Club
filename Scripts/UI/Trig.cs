using Godot;
using System;

public partial class Trig : Area2D
{
    public override void _PhysicsProcess(double delta)
    {
        GlobalPosition = GetGlobalMousePosition();
    }
}
