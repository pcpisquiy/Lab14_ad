const txtNombre = document.getElementById('nombre');
const txtNombreb = document.getElementById('txtNombreb');
const txtEdad = document.getElementById('edad');
const txtTelefono = document.getElementById('telefono');
const btnEnviar = document.getElementById('btnEnviar');

// btnEnviar.addEventListener('click',async ()=>{
// try{
   
// xhr.open("POST", url, true);
// }catch(ex){

// }

// });


txtNombreb.addEventListener("keyup", async ()=>{
    try{
        let url = "https://localhost:44337/Pacientes.asmx/ListarUsuarios";
        let Response = await fetch(url, {
            method: "POST",
            body: JSON.stringify({Nombre:txtNombreb.value})
        })
        if (Response.ok && Response.status == 200) {
            console.log(Response.json());
        }

    }catch(ex){
        alert(ex);
    }
  })