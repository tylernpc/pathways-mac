const myElement = document
  .getElementById("add-btn")
  ?.addEventListener("click", () => {
    addItem();
  });

function addItem() {
  const newItem = document.createElement("div");
  newItem.setAttribute("contenteditable", "true");

  const newImg = document.createElement('img');
  newImg.src = 'images/Trash_Full.png';
  document.getElementById('body')?.appendChild(newImg);

  const node = document.createTextNode("type here!");
  newItem.appendChild(node);

  const table = document.getElementById("find-me");
  table?.appendChild(newItem);
}

function selectItem() {
  console.log('hola world');
}

function deleteItem() {
  console.log('adios world');
}