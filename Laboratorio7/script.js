//Función agregar elemento
const bontonAgregar = document.getElementById('agregar');
const agregar = () => {
  const lista = document.getElementById('lista');
  const number = lista.childElementCount + 1;
  let elemento = document.createElement('li');
  elemento.innerText = 'Elemento' + number;
  lista.appendChild(elemento);
}
bontonAgregar.onclick = agregar;

//Función cambiar fondo
const botonFondo = document.getElementById('CambiarFondo');
const cambiarFondo = () => {
  let pageColor = document.body.style.backgroundColor;
  if (pageColor == 'white') {
    document.body.style.backgroundColor = 'cyan';
  }
  else {
    document.body.style.backgroundColor = 'white';
  }
}
botonFondo.onclick = cambiarFondo;


//Función de borrar elemento
const botonBorrar = document.getElementById('borrar');

const borrar = () => {
  const lista = document.getElementById('lista');
  let deleteIndex = lista.childElementCount - 1;
  if (deleteIndex >= 0) {
    lista.removeChild(lista.children[deleteIndex]);
  }
}
botonBorrar.onclick = borrar;


const promise = new Promise((resolve, reject) => {
  const number = Math.floor(Math.random() * 12);
  setTimeout(
    () => number > 5
      ? resolve(number)
      : reject(new Error('Menor a 4')),
    5000
  );
});

promise
  .then(number => console.log(number))
  .catch(error => console.error(error));