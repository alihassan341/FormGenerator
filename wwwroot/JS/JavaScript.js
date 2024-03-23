window.initializeDragAndDrop = function (element) {
    //if (!element || element == null) return;
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

window.openModal = function () {
    var myModal = new bootstrap.Modal(document.getElementById('modal'));
    myModal.show();
};

window.closeModal = function () {
    var myModal = new bootstrap.Modal(document.getElementById('modal'));
    myModal.hide();
};

window.copyToClipboard = function (text) {
    if (text) {
       navigator.clipboard.writeText(text);
    }
};