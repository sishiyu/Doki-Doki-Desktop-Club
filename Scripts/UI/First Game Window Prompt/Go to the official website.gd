extends Button
@onready var first_game_window_prompt: Window = $"../.."




# Called when the node enters the scene tree for the first time.

func _on_button_down() -> void:
	OS.shell_open("https://ddlc.moe")#打开心跳文学部官网
