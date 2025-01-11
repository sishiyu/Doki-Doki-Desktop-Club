extends Node
@onready var polygon_2d: Polygon2D = $"../Polygon2D"

var _api

func _ready():
	_api = get_node("/root/MouseThroughC")  # 获取 C# 脚本实例
	_api.SetClickThrough(true)  # 启用鼠标穿透功能
	DisplayServer.window_set_mouse_passthrough(polygon_2d.polygon)


func _process(_delta):
	DetectPassthrough()  # 每帧检测鼠标穿透

func DetectPassthrough():
	var viewport = get_viewport()
	var img = viewport.get_texture().get_image()
	var rect = viewport.get_visible_rect()
	var mouse_position = viewport.get_mouse_position()
	
	var viewx = int((int(mouse_position.x) + rect.position.x))
	var viewY = int((int(mouse_position.y) + rect.position.y))
	
	var x = int(img.get_size().x * viewx / rect.size.x)
	var y = int(img.get_size().y * viewY / rect.size.y)
	
	if x < img.get_size().x and x >= 0 and y < img.get_size().y and y >= 0:
		var pixel = img.get_pixel(x, y)
		if pixel.a > 0.5:
			set_click_ability(true)
		else:
			set_click_ability(false)

var click_through = true

func set_click_ability(clickable: bool):
	_api.SetClickThrough(!clickable)
	if clickable != click_through:
		click_through = clickable
