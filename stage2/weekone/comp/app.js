const userInput = document.querySelector('.user-input');
const addButton = document.querySelector('.add-btn');
const todoList = document.querySelector('.todo-list');

addButton.addEventListener('click', function(event) {
    event.preventDefault();

    if (userInput.value.trim() === ""){
        alert('Please input a value');
        return;
    }

    // creating top layer of todo, li subitem will go inside
    const topItem = document.createElement('div');
    topItem.classList.add('todo');

    // creating the list item
    const subItem = document.createElement('li');
    subItem.innerText = userInput.value.trim();
    subItem.classList.add('todo-item');
    topItem.appendChild(subItem);

    // creating a trash button
    const trashButton = document.createElement('button');
    trashButton.classList.add('trash-btn');
    trashButton.innerText = 'Delete';
    topItem.appendChild(trashButton);
    todoList.appendChild(topItem);

    trashButton.addEventListener('click', function() {
        topItem.remove();
    });

    userInput.value = '';
});