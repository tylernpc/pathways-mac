document.getElementById("submit-btn").addEventListener("click", addToList);

function addToList() {
  const userInput = document.getElementById("UserInputWord").value.trim();
  const userSelection = document.getElementById("UserSelection").value;

  validateUserInput(userInput);
  validateUserSelection(userSelection);

  listLogic(userInput, userSelection);
}

function listLogic(userInput, userSelection) {
  let tableRef;

  if (userSelection == "1") {
    tableRef = document.getElementById("myList1");
  } else if (userSelection == "2") {
    tableRef = document.getElementById("myList2");
  }

  const newRow = tableRef.inserRow();
  const newCell = newRow.insertCell(0);
  newCell.textContent = userInput;

  document.getElementById("UserInputWord").value = "";
  document.getElementById("UserSelection").value = "";
}

function validateUserInput(userInput) {
  if (userInput == "") {
    wordExist = false;
  }
  return true;
}

function validateUserSelection(userSelection) {
  if (userSelection == "") {
    alert("Please select the first or second list.");
    return false;
  }
  return true;
}
