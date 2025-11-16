function setActiveMenu(id) {
    const items = document.querySelectorAll(".component-btn");
    items.forEach(item => {
        item.classList.toggle("active", item.id === id);
    });
}