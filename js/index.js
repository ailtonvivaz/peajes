	window.addEventListener('load', function(e) {


	
		var btnespanol;
		btnespanol = document.getElementById('botonespanol');	
		
                
		// Android 2.2 needs FastClick to be instantiated before the other listeners so that the stopImmediatePropagation hack can work.
		FastClick.attach(btnespanol);		   

            
                		

		
		btnespanol.addEventListener('touchend', function(event) {
			//alert('touched on ok');
		}, false);

		btnespanol.addEventListener('click', function(event) {
			try
			  {
				alert('espanol selected.');
			  }
			catch(err)
			  {
			  //Handle errors
			  }			
		}, false);		
	
		
		
		//after fastclick instantiation and listeners setup get rest of code in load fx
		try
		  {

			var mylocation = location.hash;
			switch(mylocation){
				case '#terminosdeuso':
					//$.mobile.changePage( "#tos", { transition: "slide"} );
					break;
				case '#signin':
					//$.mobile.changePage( "#signin", { transition: "slide"} );
					break;	
				case '#lecturas':
					//$.mobile.changePage( "#lecturas", { transition: "slide"} );
					//mostrarlistadolecturas();	
					break;													
				default:	
							
			}
		  }
		catch(err)
		  {
		  //Handle errors
		  }			


function loadedOk(){
	//placeholder
}

function donothing() 
{
	//placeholder
}



//closing addeventlistener		  
	}, false);	

	
//funciones despues del load de pagina fuera del evento de load.	
function close_window() {
  if (confirm("Salir del sistema?")) {
    //window.close();
	navigator.app.exitApp();
  }
}	
	
//seleccion del segmento	
function segmento_sel(indice) {
	try
	  {
		switch(indice){
			case 1: //portacontenedores
				//$.mobile.changePage( "#tos", { transition: "slide"} );
				location.href="portacontenedores.html";
				break;
			case 7: //portavehiculos
				//$.mobile.changePage( "#signin", { transition: "slide"} );
				location.href="portavehiculos.html";
				break;												
			default:	
				alert('Este segmento aún no está habilitado.');		
		}
	  }
	catch(err)
	  {
	  //Handle errors
	  }			  
}		

	