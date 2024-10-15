let userFirstName = document.getElementById("fName").value;
let userLastName = document.getElementById("lName").value;

document.getElementById("submit-btn").addEventListener("click", displayVehicle);

function displayVehicle() {
  alert(`Hello, ${userFirstName} ${userLastName}`);
}
