extends BTAction
var character_name:String = "Monika_"#人物对话前缀
var Dialogue_progress_Monika

func _enter() -> void:
	pass


func _exit() -> void:
	pass


func _tick(_delta: float) -> Status:
	Dialogue_progress_Monika = scene_root.get_node("/root/AutoLoadData").Dialogue_progress_Monika
	Dialogic.start(character_name+str(Dialogue_progress_Monika))#播放对话
	scene_root.get_node("/root/AutoLoadData").Dialogue_progress_Monika += 1#日常进度+1
	scene_root.get_node("/root/AutoLoadData").save_player_data()#保存
	return SUCCESS
