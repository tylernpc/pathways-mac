"use strict";
var _a;
const myElement = (_a = document.getElementById('add-btn')) === null || _a === void 0 ? void 0 : _a.addEventListener('click', () => {
    addItem();
});
function addItem() {
    const newItem = document.createElement('div');
    newItem.setAttribute('contenteditable', 'true');
    const node = document.createTextNode('type here!');
    newItem.appendChild(node);
    const table = document.getElementById('find-me');
    table === null || table === void 0 ? void 0 : table.appendChild(newItem);
}
