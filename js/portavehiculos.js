	window.addEventListener('load', function(e) {
	
		var btnespanol;
		btnespanol = document.getElementById('espanol');	

		var btncalcular;
		btncalcular = document.getElementById('calcular');	
		
                
		// &&roid 2.2 needs FastClick to be instantiated before the other listeners so that the stopImmediatePropagation hack can work.
		FastClick.attach(btnespanol);		   
		FastClick.attach(btncalcular);
            
                		

		
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
			  //H&&le errors
			  }			
		}, false);		
	



		btncalcular.addEventListener('touchend', function(event) {
			//alert('touched on ok');
		}, false);

		btncalcular.addEventListener('click', function(event) {
			try
			  {
				var pMT = parseFloat(document.getElementById('vTM').value.replace(",", ""));
				var pDWT = parseFloat(document.getElementById('vDWT').value.replace(",", ""));
				var pPCUMS = parseFloat(document.getElementById('vTONELAJE').value.replace(",", ""));
				var util   = (pMT / pDWT) * 100;
				document.getElementById('span_vUTILIZACION').textContent = util.toFixed(2);
				var result = 0;
				
				// Porcentaje de utilizacion de 0.00 - 9.99
				if (util > 0 && util < 10.00 || pPCUMS == 0) {
					if (pPCUMS > 0 && pPCUMS < 25001) {
						result = pPCUMS * 3.67;
					}

					if (pPCUMS >= 25001 && pPCUMS < 62501) {
						result = pPCUMS * 3.46;
					}

					if (pPCUMS >= 62501) {
						result = pPCUMS * 3.43;
					}
				}

				// Porcentaje de utilizacion de 10.00 - 19.99
				if (util >= 10 && util < 20 && pPCUMS > 0)  {
					if (pPCUMS > 0 && pPCUMS < 25001) {
						result = pPCUMS * 4.97;
					}

					if (pPCUMS >= 25001 && pPCUMS < 62501) {
						result = pPCUMS * 4.26;
					}

					if (pPCUMS >= 62501) {
						result = pPCUMS * 4.21;
					}
				}

				// Porcentaje de utilizacion de 20.00 - 29.99
				if (util >= 20 && util < 30 && pPCUMS > 0)  {
					if (pPCUMS > 0 && pPCUMS < 25001) {
						result = pPCUMS * 5.01;
					}

					if (pPCUMS >= 25001 && pPCUMS < 62501) {
						result = pPCUMS * 4.31
					}

					if (pPCUMS >= 62501) {
						result = pPCUMS * 4.28;
					}
				}

				// Porcentaje de utilizacion de 30.00 - 39.99
				if (util >= 30 && util < 40 && pPCUMS > 0)  {
					if (pPCUMS > 0 && pPCUMS < 25001) {
						result = pPCUMS * 5.06;
					}

					if (pPCUMS >= 25001 && pPCUMS < 62501) {
						result = pPCUMS * 4.34;
					}

					if (pPCUMS >= 62501) {
						result = pPCUMS * 4.34;
					}
				}

				// Porcentaje de utilizacion de 40.00 - 49.99
				if (util >= 40 && util < 50 && pPCUMS > 0)  {
					if (pPCUMS > 0 && pPCUMS < 25001) {
						result = pPCUMS * 5.15;
					}

					if (pPCUMS >= 25001 && pPCUMS < 62501) {
						result = pPCUMS * 4.38
					}

					if (pPCUMS >= 62501) {
						result = pPCUMS * 4.35;
					}
				}

				// Porcentaje de utilizacion de 50.00 - up
				if (util >= 50) {
					if (pPCUMS > 0 && pPCUMS < 25001 && pPCUMS > 0)  {
						result = pPCUMS * 5.21;
					}

					if (pPCUMS >= 25001 && pPCUMS < 62501) {
						result = pPCUMS * 4.45;
					}

					if (pPCUMS >= 62501) {
						result = pPCUMS * 4.43;
					}
				}

				result = result.toFixed(2);
				document.getElementById('RESULTADOCALCULO').textContent = result.toString().replace(/(\d)(?=(\d{3})+(?!\d))/g, "$1,");

			  }
			catch(err)
			  {
			  //H&&le errors
			  }			
		}, false);		
	
		
		//after fastclick instantiation && listeners setup get rest of code in load fx
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
		  //H&&le errors
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
	