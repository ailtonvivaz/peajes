function ImageLoader()
{
	this.Height = 0;
	this.Width = 0;
	this.AlternateText = "";
	this.TooltipText = "";
	this.Class = "Image";
	this.LoadingImage = "";
	this.InitialImage = "";

	this.show = function() {
	    if (this.InitialImage != "")
	        this.LoadImage(this.InitialImage);
	};
	///UserCodeRegionStart:[User Functions] (do not remove this comment.)
	
	this.LoadImage = function(url, alt, ttip)
	{
		this.Image = url;
		this.AlternateText = alt || this.AlternateText;
		this.TooltipText = ttip || this.TooltipText;
		
		var loadingImg = this.LoadingImage;
		if (!this.LoadingImage){
			loadingImg = gx.util.resourceUrl(this.format("{0}{1}{2}/{3}", gx.basePath, gx.staticDirectory, "ImageLoader", "loading.gif"), true);
		}
		
		var style = new gx.text.stringBuffer();
		style.clear();
		if (this.Height){
			style.append(this.format("height:{0};", this.Height));
		}
		if (this.Width){
			style.append(this.format("width:{0};", this.Width));
		}
		var imgHtml = this.format('<img src="{0}" alt="{1}" title="{2}" style="{3}" class="{4}" />', loadingImg, this.AlternateText, this.TooltipText, "", this.Class);
		var dummyImgHtml = this.format('<img src="{0}" style="width:0px;height:0px;border:0px;margin:0px;padding:0px;" />', this.Image);
		this.getContainerControl().innerHTML = imgHtml + dummyImgHtml;
		
		var img = this.getContainerControl().childNodes[0];
		var dummyImg = this.getContainerControl().childNodes[1];
		
		var that = this;
		gx.evt.attach(dummyImg, "load", function(){
			dummyImg.alt = img.alt;
			dummyImg.title = img.title;
			dummyImg.className = img.className;
			dummyImg.style.cssText = style.toString();
			that.getContainerControl().removeChild(img);
		});
	};

    this.format = function(format){
        var args = Array.prototype.slice.call(arguments, 1);
        return format.replace(/\{(\d+)\}/g, function(m, i){
            return args[i];
        });
    };
	///UserCodeRegionEnd: (do not remove this comment.):
}
