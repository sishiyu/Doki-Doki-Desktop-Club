using Godot;
using System;

public partial class direction_left : BTAction
{
     public override void _Enter()
    {
    }

    public override void _Exit()
    {
    }

    public override Status _Tick(double delta)
    {
        if(SceneRoot.GetNode<Movements>("movements").character_direction)//角色方向为左向，返回Success
        return Status.Success;
        else
        return Status.Failure;//角色方向为右向，返回Failure
    }
}
