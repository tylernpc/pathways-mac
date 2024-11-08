document.addEventListener('DOMContentLoaded', () => {
    const draggables = document.querySelectorAll('.list');
    const droppableTodo = document.getElementById('Todo');
    const droppableWorkingOn = document.getElementById('WorkinOn');
    const droppableDone = document.getElementById('Done');

    draggables.forEach(draggable => {
        draggable.addEventListener('dragstart', () => {
            draggable.classList.add('dragging');
        });

        draggable.addEventListener('dragend', () => {
            draggable.classList.remove('dragging');
        });
    });

    [droppableTodo, droppableWorkingOn, droppableDone].forEach(droppable => {
        droppable.addEventListener('dragover', (event) => {
            event.preventDefault();
        });

        droppable.addEventListener('drop', (event) => {
            const draggable = document.querySelector('.dragging');
            droppable.appendChild(draggable);
        });
    });
});