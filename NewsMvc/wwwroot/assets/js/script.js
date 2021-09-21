$(window).load(function () {
    // Animate loader off screen
    $(".se-pre-con").fadeOut("slow");;
});

$(document).ready(function () {
    // for navbar side menu------------------------------------------------------
    $(".fa-search").click(function (e) {
        e.preventDefault();
        $(".top-search").slideToggle("show");
    });

    $(".side-menu-icon").click(function (e) {
        e.preventDefault();
        $(".side-menu").addClass("open")
    });

    $(".close-side").click(function (e) {
        e.preventDefault();
        $(".side-menu").removeClass("open")
    })
    //--------------------------------------------------------------------------------------


});
let navItem = document.querySelectorAll(".navbar-nav .nav-item");
navItem.forEach((elem) => {
    elem.addEventListener("click", function () {
        navItem.forEach(elm=>elm.classList.remove("active"));
        this.classList.add("active");
    });
});

let pageItem = document.querySelectorAll(".pagination .page-item");
pageItem.forEach((elem) => {
    elem.addEventListener("click", function () {
        pageItem.forEach(elm=>elm.classList.remove("page-active"));
        this.classList.add("page-active");
    });
});