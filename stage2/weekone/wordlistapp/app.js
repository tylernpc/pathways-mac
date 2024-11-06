document.getElementById("userPromptForm").addEventListener("submit", function(event) {
  event.preventDefault();
  addToList(); 
});

function addToList() {
  const userInput = document.getElementById("UserInputWord").value.trim();
  const userSelection = document.getElementById("UserSelection").value;

  if (validateUserInput(userInput) && validateUserSelection(userSelection)) {
    listLogic(userInput, userSelection);
  }  
}

function listLogic(userInput, userSelection) {
  let tableRef;

  if (userSelection == "1") {
    tableRef = document.getElementById("myList1");
  } else if (userSelection == "2") {
    tableRef = document.getElementById("myList2");
  }

  const newRow = tableRef.insertRow();
  const newCell = newRow.insertCell(0);
  newCell.textContent = userInput;

  document.getElementById("UserInputWord").value = "";
  document.getElementById("UserSelection").value = "";
}

// validation
function validateUserInput(userInput) {
  if (userInput == "") { 
    return false;
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

// clear logic
document.getElementById("clear-btn-1").addEventListener("click", function() {
  clearList("myList1");
});

document.getElementById("clear-btn-2").addEventListener("click", function() {
  clearList("myList2");
});

function clearList(listId) {
  const tableRef = document.getElementById(listId);
  tableRef.innerHTML = ""; 
}