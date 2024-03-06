

//function dragAndDrop(classname) {
//    const position = { x: 0, y: 0 }

//    interact('.draggable').draggable({
//        listeners: {
//            start(event) {
//                console.log(event.type, event.target)
//            },
//            move(event) {
//                position.x += event.dx
//                position.y += event.dy

//                event.target.style.transform =
//                    `translate(${position.x}px, ${position.y}px)`
//            },
//        }
//    })
//}

// wwwroot/_content/{YourProjectName}/interact.js
window.initializeDragAndDrop = function (element) {
    interact(element).draggable({
        listeners: {
            start(event) {
                console.log(event.type, event.target);
            },
            move(event) {
                const x = (parseFloat(event.target.getAttribute('data-x')) || 0) + event.dx;
                const y = (parseFloat(event.target.getAttribute('data-y')) || 0) + event.dy;

                event.target.style.transform = `translate(${x}px, ${y}px)`;

                event.target.setAttribute('data-x', x);
                event.target.setAttribute('data-y', y);
            },
        },
    });
};