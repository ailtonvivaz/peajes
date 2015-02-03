	window.addEventListener('load', function(e) {


	
		var btnespanol;
		btnespanol = document.getElementById('botonespanol');	

		var btncalcular;
		btncalcular = document.getElementById('calcular');	
		
                
		// Android 2.2 needs FastClick to be instantiated before the other listeners so that the stopImmediatePropagation hack can work.
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
			  //Handle errors
			  }			
		}, false);		
	



		btncalcular.addEventListener('touchend', function(event) {
			//alert('touched on ok');
		}, false);

		btncalcular.addEventListener('click', function(event) {
			try
			  {				
				var vCapacidad = parseFloat(document.getElementById('vCAPACIDADDECONTENEDORES').value.replace(",", ""));
				var vCarga = parseFloat(document.getElementById('vCARGATEU').value.replace(",", ""));
				var util   = (vCarga / vCapacidad) * 100;
				document.getElementById('span_vPORCENTAJEDECARGA').textContent = util.toFixed(2);

				// Tarifa Regular
				// Panamax
				var vCalculoTTA = 0; 
				var vCalculoTEU = 0;
				var result = 0;
				if (vCapacidad < 6000) {
					if (vCarga >= 1000 && vCarga < 2000) {
						vCalculoTTA = vCapacidad * 60
						vCalculoTEU = vCarga * 30
					}

					if (vCarga >= 2000 && vCarga < 3500) {
						vCalculoTTA = vCapacidad * 60
						vCalculoTEU = vCarga * 30
					}

					if (vCarga >= 3500) {
						vCalculoTTA = vCapacidad * 60
						vCalculoTEU = vCarga * 30
					}
				}
				
				result = vCalculoTTA + vCalculoTEU;
				result = result.toFixed(2);
				if (result != 0.00) {
					document.getElementById('RESULTADOPANAMAX').textContent = result.toString().replace(/(\d)(?=(\d{3})+(?!\d))/g, "$1,");
				} else {
					document.getElementById('RESULTADOPANAMAX').textContent = "N/A";
				}

				// Neopanamax
				var vCalculoTTA = 0; 
				var vCalculoTEU = 0;
				var result = 0;
				if (vCapacidad < 6000) {
					vCalculoTTA = vCapacidad * 60
					vCalculoTEU = vCarga * 40
				}

				if (vCapacidad >= 6000 && vCapacidad < 7000) {
					vCalculoTTA = vCapacidad * 50
					vCalculoTEU = vCarga * 40
				}

				if (vCapacidad >= 7000 && vCapacidad < 8000) {
					vCalculoTTA = vCapacidad * 50
					vCalculoTEU = vCarga * 40
				}

				if (vCapacidad >= 8000 && vCapacidad < 9000) {
					vCalculoTTA = vCapacidad * 50
					vCalculoTEU = vCarga * 40
				}

				if (vCapacidad >= 9000 && vCapacidad < 10000) {
					vCalculoTTA = vCapacidad * 50
					vCalculoTEU = vCarga * 35
				}

				if (vCapacidad >= 10000 && vCapacidad < 11000) {
					vCalculoTTA = vCapacidad * 50
					vCalculoTEU = vCarga * 35
				}

				if (vCapacidad >= 11000 && vCapacidad < 12000) {
					vCalculoTTA = vCapacidad * 50
					vCalculoTEU = vCarga * 35
				}

				if (vCapacidad >= 12000) {
					vCalculoTTA = vCapacidad * 50
					vCalculoTEU = vCarga * 35
				}
				var result = vCalculoTTA + vCalculoTEU;
				result = result.toFixed(2);
				document.getElementById('RESULTADONEOPANAMAX').textContent = result.toString().replace(/(\d)(?=(\d{3})+(?!\d))/g, "$1,");

				// Tarifa Categoria 3
				// Panamax
				var vCalculoTTA = 0; 
				var vCalculoTEU = 0;
				var result = 0;
				if (vCapacidad < 6000) {
					if (vCarga >= 1000 && vCarga < 2000) {
						vCalculoTTA = vCapacidad * 59
						vCalculoTEU = vCarga * 30
					}

					if (vCarga >= 2000 && vCarga < 3500) {
						vCalculoTTA = vCapacidad * 59
						vCalculoTEU = vCarga * 30
					}

					if (vCarga >= 3500) {
						vCalculoTTA = vCapacidad * 59
						vCalculoTEU = vCarga * 30
					}
				}
				var result = vCalculoTTA + vCalculoTEU;
				result = result.toFixed(2);
				if (result != 0.00) {
					document.getElementById('RESULTADOPANAMAXC3').textContent = result.toString().replace(/(\d)(?=(\d{3})+(?!\d))/g, "$1,");
				} else {
					document.getElementById('RESULTADOPANAMAXC3').textContent = "N/A";
				}

				// Neopanamax
				var vCalculoTTA = 0; 
				var vCalculoTEU = 0;
				var result = 0;
				if (vCapacidad < 6000) {
					vCalculoTTA = vCapacidad * 59
					vCalculoTEU = vCarga * 40
				}

				if (vCapacidad >= 6000 && vCapacidad < 7000) {
					vCalculoTTA = vCapacidad * 49
					vCalculoTEU = vCarga * 40
				}

				if (vCapacidad >= 7000 && vCapacidad < 8000) {
					vCalculoTTA = vCapacidad * 49
					vCalculoTEU = vCarga * 40
				}

				if (vCapacidad >= 8000 && vCapacidad < 9000) {
					vCalculoTTA = vCapacidad * 49
					vCalculoTEU = vCarga * 40
				}

				if (vCapacidad >= 9000 && vCapacidad < 10000) {
					vCalculoTTA = vCapacidad * 49
					vCalculoTEU = vCarga * 35
				}

				if (vCapacidad >= 10000 && vCapacidad < 11000) {
					vCalculoTTA = vCapacidad * 49
					vCalculoTEU = vCarga * 35
				}

				if (vCapacidad >= 11000 && vCapacidad < 12000) {
					vCalculoTTA = vCapacidad * 49
					vCalculoTEU = vCarga * 35
				}

				if (vCapacidad >= 12000) {
					vCalculoTTA = vCapacidad * 49
					vCalculoTEU = vCarga * 35
				}
				var result = vCalculoTTA + vCalculoTEU;
				result = result.toFixed(2);
				document.getElementById('RESULTADONEOPANAMAXC3').textContent = result.toString().replace(/(\d)(?=(\d{3})+(?!\d))/g, "$1,");

				// Tarifa Categoria 2
				// Panamax
				var vCalculoTTA = 0; 
				var vCalculoTEU = 0;
				var result = 0;
				if (vCapacidad < 6000) {
					if (vCarga >= 1000 && vCarga < 2000) {
						vCalculoTTA = vCapacidad * 58
						vCalculoTEU = vCarga * 30
					}

					if (vCarga >= 2000 && vCarga < 3500) {
						vCalculoTTA = vCapacidad * 58
						vCalculoTEU = vCarga * 30
					}

					if (vCarga >= 3500) {
						vCalculoTTA = vCapacidad * 58
						vCalculoTEU = vCarga * 30
					}
				}
				var result = vCalculoTTA + vCalculoTEU;
				result = result.toFixed(2);
				if (result != 0.00) {
					document.getElementById('RESULTADOPANAMAXC2').textContent = result.toString().replace(/(\d)(?=(\d{3})+(?!\d))/g, "$1,");
				} else {
					document.getElementById('RESULTADOPANAMAXC2').textContent = "N/A";
				}

				// Neopanamax
				var vCalculoTTA = 0; 
				var vCalculoTEU = 0;
				var result = 0;
				if (vCapacidad < 6000) {
					vCalculoTTA = vCapacidad * 58
					vCalculoTEU = vCarga * 40
				}

				if (vCapacidad >= 6000 && vCapacidad < 7000) {
					vCalculoTTA = vCapacidad * 48
					vCalculoTEU = vCarga * 40
				}

				if (vCapacidad >= 7000 && vCapacidad < 8000) {
					vCalculoTTA = vCapacidad * 48
					vCalculoTEU = vCarga * 40
				}

				if (vCapacidad >= 8000 && vCapacidad < 9000) {
					vCalculoTTA = vCapacidad * 48
					vCalculoTEU = vCarga * 40
				}

				if (vCapacidad >= 9000 && vCapacidad < 10000) {
					vCalculoTTA = vCapacidad * 48
					vCalculoTEU = vCarga * 35
				}

				if (vCapacidad >= 10000 && vCapacidad < 11000) {
					vCalculoTTA = vCapacidad * 48
					vCalculoTEU = vCarga * 35
				}

				if (vCapacidad >= 11000 && vCapacidad < 12000) {
					vCalculoTTA = vCapacidad * 48
					vCalculoTEU = vCarga * 35
				}

				if (vCapacidad >= 12000) {
					vCalculoTTA = vCapacidad * 48
					vCalculoTEU = vCarga * 35
				}
				var result = vCalculoTTA + vCalculoTEU;
				result = result.toFixed(2);
				document.getElementById('RESULTADONEOPANAMAXC2').textContent = result.toString().replace(/(\d)(?=(\d{3})+(?!\d))/g, "$1,");

				// Tarifa Categoria 1
				// Panamax
				var vCalculoTTA = 0; 
				var vCalculoTEU = 0;
				var result = 0;
				if (vCapacidad < 6000) {
					if (vCarga >= 1000 && vCarga < 2000) {
						vCalculoTTA = vCapacidad * 57
						vCalculoTEU = vCarga * 30
					}

					if (vCarga >= 2000 && vCarga < 3500) {
						vCalculoTTA = vCapacidad * 57
						vCalculoTEU = vCarga * 30
					}

					if (vCarga >= 3500) {
						vCalculoTTA = vCapacidad * 57
						vCalculoTEU = vCarga * 30
					}
				}
				var result = vCalculoTTA + vCalculoTEU;
				result = result.toFixed(2);
				if (result != 0.00) {
					document.getElementById('RESULTADOPANAMAXC1').textContent = result.toString().replace(/(\d)(?=(\d{3})+(?!\d))/g, "$1,");
				} else {
					document.getElementById('RESULTADOPANAMAXC1').textContent = "N/A";
				}

				// Neopanamax
				var vCalculoTTA = 0; 
				var vCalculoTEU = 0;
				var result = 0;
				if (vCapacidad < 6000) {
					vCalculoTTA = vCapacidad * 57
					vCalculoTEU = vCarga * 40
				}

				if (vCapacidad >= 6000 && vCapacidad < 7000) {
					vCalculoTTA = vCapacidad * 47
					vCalculoTEU = vCarga * 40
				}

				if (vCapacidad >= 7000 && vCapacidad < 8000) {
					vCalculoTTA = vCapacidad * 47
					vCalculoTEU = vCarga * 40
				}

				if (vCapacidad >= 8000 && vCapacidad < 9000) {
					vCalculoTTA = vCapacidad * 47
					vCalculoTEU = vCarga * 40
				}

				if (vCapacidad >= 9000 && vCapacidad < 10000) {
					vCalculoTTA = vCapacidad * 47
					vCalculoTEU = vCarga * 35
				}

				if (vCapacidad >= 10000 && vCapacidad < 11000) {
					vCalculoTTA = vCapacidad * 47
					vCalculoTEU = vCarga * 35
				}

				if (vCapacidad >= 11000 && vCapacidad < 12000) {
					vCalculoTTA = vCapacidad * 47
					vCalculoTEU = vCarga * 35
				}

				if (vCapacidad >= 12000) {
					vCalculoTTA = vCapacidad * 47
					vCalculoTEU = vCarga * 35
				}
				var result = vCalculoTTA + vCalculoTEU;
				result = result.toFixed(2);
				document.getElementById('RESULTADONEOPANAMAXC1').textContent = result.toString().replace(/(\d)(?=(\d{3})+(?!\d))/g, "$1,");

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
	