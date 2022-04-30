/* =========== Show Navbar =========== */

function onLoadJs() {
    let sidebar = document.querySelector('.sidebar')

    document.querySelector('#menu-btn').onclick = () => {
        sidebar.classList.toggle('active');
    }
}

