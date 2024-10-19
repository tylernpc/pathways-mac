const userInput = document.querySelector(".user-input");
const addButton = document.querySelector(".add-btn");
const todoList = document.querySelector(".todo-list");

userInput.addEventListener("input", function () {
  if (userInput.value.length > 55) {
    userInput.value = userInput.value.slice(0, 55);
  }
});

addButton.addEventListener("click", function (event) {
  event.preventDefault();

  if (userInput.value.trim() === "") {
    alert("Please input a value");
    return;
  }

  // creating top layer of todo, li subitem will go inside
  const topItem = document.createElement("div");
  topItem.classList.add("single-item");

  // creating the list item
  const subItem = document.createElement("li");
  subItem.innerText = userInput.value.trim();
  subItem.classList.add("todo-item");
  topItem.appendChild(subItem);
  subItem.setAttribute("contenteditable", "true");

  subItem.addEventListener("input", function () {
    if (subItem.innerText.length > 55) {
      subItem.innerText = subItem.innerText.slice(0, 55);
    }
  });

  // creating a trash button
  const trashButton = document.createElement("button");
  trashButton.classList.add("trash-btn");
  trashButton.innerText = "Delete";
  topItem.appendChild(trashButton);
  todoList.appendChild(topItem);

  // creating a complete button
  const completeButton = document.createElement("button");

  trashButton.addEventListener("click", function () {
    topItem.remove();
  });

  userInput.value = "";
});
