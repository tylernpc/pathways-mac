"use strict";
var _a;
const myElement = (_a = document
    .getElementById("add-btn")) === null || _a === void 0 ? void 0 : _a.addEventListener("click", () => {
    addItem();
});
function addItem() {
    var _a;
    const newItem = document.createElement("div");
    newItem.setAttribute("contenteditable", "true");
    const newImg = document.createElement('img');
    newImg.src = 'images/Trash_Full.png';
    (_a = document.getElementById('body')) === null || _a === void 0 ? void 0 : _a.appendChild(newImg);
    const node = document.createTextNode("type here!");
    newItem.appendChild(node);
    const table = document.getElementById("find-me");
    table === null || table === void 0 ? void 0 : table.appendChild(newItem);
}
function selectItem() {
    console.log('hola world');
}
function deleteItem() {
    console.log('adios world');
}
let res = document.getElementById('result');
function GFG_Fun() {
    let img = document.createElement('img');
    img.src = 'images/Trash_Full.png';
    document.getElementById('body'.appendChild(img));
    res.innerHTML = "Image Element Added.";
}
