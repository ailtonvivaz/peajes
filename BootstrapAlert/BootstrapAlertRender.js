function BootstrapAlert()
{
	this.Width;
	this.Height;

	this.show = function()
	{
		///UserCodeRegionStart:[show] (do not remove this comment.)

		gx.fx.obs.addObserver('gx.onmessages',this,this.onmessages_notify)
				
		if(!this.IsPostBack){
			this.setAlert();
		}
	    			
		
		
		
		
		
		
		///UserCodeRegionEnd: (do not remove this comment.)
	}
	///UserCodeRegionStart:[User Functions] (do not remove this comment.)
	

	this.onmessages_notify = function(messages){
			
		if(messages){
			this.showMessages(messages);
		}
		
	}

	this.showMessages = function (messages){

		if(messages['MAIN'].length > 0 )
		 {
		 
			 msgs = messages['MAIN'];
			 messages['MAIN'] = [];
			
		 }
        
		var buffer = new gx.text.stringBuffer();
		buffer.clear();
	

		buffer.append('<div id="uc-alert-container">');
		$.each(msgs, function(index, value) {
           
		    var cssclass = "alert-warning";	
			var messageText = value.text;
			
			if(messageText.indexOf("[[warning]]") != -1){
				cssclass = "alert-warning"; 
				messageText = messageText.replace("[[warning]]","");  
			};
			
			if(messageText.indexOf("[[danger]]")!= -1){ 
				cssclass = "alert-danger"; 
				messageText = messageText.replace("[[danger]]","");
			};
			
			if(messageText.indexOf("[[success]]") != -1){ 
				cssclass = "alert-success";
				messageText= messageText.replace("[[success]]","");
			};
			
			if(messageText.indexOf("[[info]]") != -1){ 
				cssclass = "alert-info";
				messageText= messageText.replace("[[info]]","");
			};
			
			buffer.append('<div class="alert alert-dismissable ' + cssclass +'">');
  			buffer.append('<button type="button" class="close" data-dismiss="alert" aria-hidden="true">&times;</button>');
  			buffer.append(' '+messageText+'');
			buffer.append('</div>');
			
			
        });
		
		buffer.append('</div>');
		
			
		if($('#gxErrorViewer').length > 1){
			    
			$('#gxErrorViewer')[0].after(buffer.toString());
		}
		else {
	
			$('#uc-alert-container').empty();
			$('#gxErrorViewer').after(buffer.toString());
			$('#gxErrorViewer').empty();
		};
												
	};
	
	this.setAlert = function() {
		
		var divErrors = $('#gxErrorViewer').children();	
		   				 
		var msgsArr = [];
		   
		$.each(divErrors, function(index, value) {
			msgsArr.push({ att: '', type: 0, text: $(value).html() });				
		});
		
		if(msgsArr.length > 0){
			var msgs = {};
			
			msgs['MAIN'] = msgsArr;
			
			this.showMessages(msgs);								
		}
	}
	
	
	
	

	
	
	
	
	
	
	
	
	///UserCodeRegionEnd: (do not remove this comment.):
}
