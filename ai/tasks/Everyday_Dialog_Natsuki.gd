extends BTAction
var character_name:String = "Natsuki_"#人物对话前缀
var Dialogue_progress_Natsuki

func _enter() -> void:
	pass


func _exit() -> void:
	pass


func _tick(_delta: float) -> Status:
	Dialogue_progress_Natsuki = scene_root.get_node("/root/AutoLoadData").Dialogue_progress_Natsuki
	Dialogic.start(character_name+str(Dialogue_progress_Natsuki))#播放对话
	scene_root.get_node("/root/AutoLoadData").Dialogue_progress_Natsuki += 1#日常进度+1
	scene_root.get_node("/root/AutoLoadData").save_player_data()#保存
	return SUCCESS
