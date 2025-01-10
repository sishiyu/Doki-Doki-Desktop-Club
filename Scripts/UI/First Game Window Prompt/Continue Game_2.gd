extends Button
@onready var first_game_window_prompt: Window = $"../.."


#
func _on_button_down() -> void:
	first_game_window_prompt.queue_free()#删除弹窗
