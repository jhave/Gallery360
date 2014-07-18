enum EaseType {None, In, Out, InOut}
static var use : Fade;
 
function Awake () {
	if (use) {
		Debug.LogWarning("Only one instance of the Fade script in a scene is allowed");
		return;
	}
	use = this;
}
 
function Alpha (object : Object, start : float, end : float, timer : float) {
	yield Alpha(object, start, end, timer, EaseType.None);
}
 
function Alpha (object : Object, start : float, end : float, timer : float, easeType : EaseType) {
	if (!CheckType(object)) return;
	var t = 0.0;
	var objectType = typeof(object);
	while (t < 1.0) {
		t += Time.deltaTime * (1.0/timer);
		if (objectType == GUITexture)
			(object as GUITexture).color.a = Mathf.Lerp(start, end, Ease(t, easeType)) * .5;
		else
			(object as Material).color.a = Mathf.Lerp(start, end, Ease(t, easeType));
		yield;
	}
}
 
function Colors (object : Object, start : Color, end : Color, timer : float) {
	yield Colors(object, start, end, timer, EaseType.None);
}
 
function Colors (object : Object, start : Color, end : Color, timer : float, easeType : EaseType) {
	if (!CheckType(object)) return;
	var t = 0.0;
	var objectType = typeof(object);
	while (t < 1.0) {
		t += Time.deltaTime * (1.0/timer);
		if (objectType == GUITexture)
			(object as GUITexture).color = Color.Lerp(start, end, Ease(t, easeType)) * .5;
		else
			(object as Material).color = Color.Lerp(start, end, Ease(t, easeType));
		yield;
	}
}
 
function Colors (object : Object, colorRange : Color[], timer : float, repeat : boolean) {
	if (!CheckType(object)) return;
	if (colorRange.Length < 2) {
		Debug.LogError("Error: color array must have at least 2 entries");
		return;
	}
	timer /= colorRange.Length;
	var i = 0;
	var objectType = typeof(object);
	while (true) {
		var t = 0.0;
		while (t < 1.0) {
			t += Time.deltaTime * (1.0/timer);
			if (objectType == GUITexture)
				(object as GUITexture).color = Color.Lerp(colorRange[i], colorRange[(i+1) % colorRange.Length], t) * .5;
			else
				(object as Material).color = Color.Lerp(colorRange[i], colorRange[(i+1) % colorRange.Length], t);
			yield;
		}
		i = ++i % colorRange.Length;
		if (!repeat && i == 0) break;
	}	
}
 
private function Ease (t : float, easeType : EaseType) : float {
	if (easeType == EaseType.None)
		return t;
	else if (easeType == EaseType.In)
		return Mathf.Lerp(0.0, 1.0, 1.0 - Mathf.Cos(t * Mathf.PI * .5));
	else if (easeType == EaseType.Out)
		return Mathf.Lerp(0.0, 1.0, Mathf.Sin(t * Mathf.PI * .5));
	else
		return Mathf.SmoothStep(0.0, 1.0, t);
}
 
private function CheckType (object : Object) : boolean {
	if (typeof(object) != GUITexture && typeof(object) != Material) {
		Debug.LogError("Error: object is a " + typeof(object) + ". It must be a GUITexture or a Material");
		return false;
	}
	return true;
}