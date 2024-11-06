function updateName() {
  let userName = document.getElementById("fName").value;
  document.getElementById("displayName").innerHTML =
    `Greetings ${userName} the earthling`;
}
