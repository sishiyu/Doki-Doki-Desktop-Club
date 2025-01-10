extends AudioStreamPlayer


# Called when the node enters the scene tree for the first time.
func _ready() -> void:
	Dialogic.signal_event.connect(on_BGM)#连接对话信号


# Called every frame. 'delta' is the elapsed time since the previous frame.
func on_BGM(signal_:String):#播放bgm
	if (signal_ == "BGM"):
		play()
