extends Node

@export var jumpAI:Node
@export var dialogAI:Node

func _ready() -> void:
	Dialogic.VAR.PlayerName = get_node("/root/AutoLoadData").playerName


func Close_JumpAI():#关闭跳动ai
	jumpAI.process_mode = Node.PROCESS_MODE_DISABLED

func  Close_DialogAI():#关闭对话ai
	dialogAI.process_mode = Node.PROCESS_MODE_DISABLED

func Open_JumpAI():#开启跳动ai
	jumpAI.process_mode = Node.PROCESS_MODE_INHERIT

func  Open_DialogAI():#开启对话ai
	dialogAI.process_mode = Node.PROCESS_MODE_INHERIT
