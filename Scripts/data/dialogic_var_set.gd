extends Node

func _ready() -> void:
	Dialogic.VAR.PlayerName = get_node("/root/AutoLoadData").playerName
