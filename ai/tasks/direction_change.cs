using Godot;
using System;

public partial class direction_change : BTAction
{
     public override void _Enter()
    {
        if(SceneRoot.GetNode<Movements>("movements").character_direction)//角色方向为左向
        SceneRoot.GetNode<Movements>("movements").character_direction = false;//角色方向设置为右向
        else
        SceneRoot.GetNode<Movements>("movements").character_direction = true;//角色方向设置为左向
    }

    public override void _Exit()
    {
    }

    public override Status _Tick(double delta)
    {
        return Status.Success;
    }
}
