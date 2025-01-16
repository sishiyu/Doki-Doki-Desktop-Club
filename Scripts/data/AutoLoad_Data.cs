using Godot;
using System;

public partial class AutoLoad_Data : Node
{
    [Export]public string playerName;//玩家名字
    [Export]public string desktopCharacter;//桌面角色
    [Export]public bool firstGame = true;//是否是第一次游戏
    [Export]public String language = "zh_CN";//语言
    [Export]public int Dialogue_progress_Sayori = 1;//Sayori日常对话进度
    [Export]public int Dialogue_progress_Monika = 1;//Monika日常对话进度


    Player_Data player_data;//玩家数据文件

    public override void _Ready()
    {
      
        
      if(Godot.FileAccess.FileExists("user://player_data.tres"))//如果玩家数据文件存在
	   {
          Player_Data player_Data_file = ResourceLoader.Load("user://player_data.tres") as Player_Data;//加载玩家数据文件

                      playerName = player_Data_file.player_name;//获取玩家名字
                      desktopCharacter = player_Data_file.Desktop_Character;//获取桌面角色
                      firstGame = player_Data_file.firstGame;;//获取是否第一次游戏
                      language = player_Data_file.language;//获取语言
                      Dialogue_progress_Sayori = player_Data_file.Dialogue_progress_Sayori;//获取Sayori日常对话进度
                      Dialogue_progress_Monika = player_Data_file.Dialogue_progress_Monika;//获取Monika日常对话进度

                      
                      TranslationServer.SetLocale(language);//设置语言

          if(player_Data_file.player_name!= ""&& desktopCharacter== "")//如果玩家名字不为空且桌面角色为空
	           {
		         GetTree().CallDeferred("change_scene_to_file","res://Scenes/UI/select_character.tscn");//切换到选择角色界面
	           }
               else if(desktopCharacter!= "")//桌面角色不为空
               {
                GetTree().CallDeferred("change_scene_to_file","res://Scenes/characters/"+desktopCharacter+".tscn");//切换到桌面角色的场景
               }
       }
    }

    public void Change_language()//切换语言
    {
        TranslationServer.SetLocale(language);//设置语言
    }

    public void save_player_data()//保存玩家数据
    {
        Player_Data player_Data_file = new Player_Data();
        player_Data_file.player_name = playerName;//保存玩家名字
        player_Data_file.Desktop_Character = desktopCharacter;//保存桌面角色
        player_Data_file.firstGame = firstGame;//保存是否第一次游戏
        player_Data_file.language = language;//保存语言
        player_Data_file.Dialogue_progress_Sayori = Dialogue_progress_Sayori;//保存Sayori日常对话进度
        player_Data_file.Dialogue_progress_Monika = Dialogue_progress_Monika;//保存Monika日常对话进度
        ResourceSaver.Save( player_Data_file,"user://player_data.tres");//导入玩家数据文件
    }
}
