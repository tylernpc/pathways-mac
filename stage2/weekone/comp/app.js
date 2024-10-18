const myElement = document
  .getElementById("add-btn")
  ?.addEventListener("click", () => {
    addItem();
  });

function addItem() {
  const newItem = document.createElement('div');
  const trashBtn = document.createElement("button");
  newItem.setAttribute('contenteditable', 'true');
  trashBtn.innerHTML = '<i class="fas fa-plus-circle fa-lg"></i>';

  const node = document.createTextNode('type here!');
  newItem.appendChild(node);

  const table = document.getElementById('find-me');
  table?.appendChild(newItem);

  trashBtn.classList.add('trash-btn');
  table.appendChild(trashBtn);
}

function deleteItem() {
  document.getElementById('trash-btn');
}