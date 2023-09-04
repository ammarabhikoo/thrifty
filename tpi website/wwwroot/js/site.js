$(".form")
    .find("input, textarea")
    .on("keyup blur focus", function (e) {
        var $this = $(this),
            label = $this.prev("label");

        if (e.type === "keyup") {
            if ($this.val() === "") {
                label.removeClass("active highlight");
            } else {
                label.addClass("active highlight");
            }
        } else if (e.type === "blur") {
            if ($this.val() === "") {
                label.removeClass("active highlight");
            } else {
                label.removeClass("highlight");
            }
        } else if (e.type === "focus") {
            if ($this.val() === "") {
                label.removeClass("highlight");
            } else if ($this.val() !== "") {
                label.addClass("highlight");
            }
        }
    });

$(".tab a").on("click", function (e) {
    e.preventDefault();

    $(this).parent().addClass("active");
    $(this).parent().siblings().removeClass("active");

    target = $(this).attr("href");

    $(".tab-content > div").not(target).hide();

    $(target).fadeIn(600);
});

/* FAQ drop down */
const items = document.querySelectorAll('.accordion button');
function toggleAccordion() {
    const itemToggle = this.getAttribute('aria-expanded');
    for (i = 0; i < items.length; i++) {
        items[i].setAttribute('aria-expanded', 'false');
    }
    if (itemToggle == 'false') {
        this.setAttribute('aria-expanded', 'true');
    }
}
items.forEach((item) => item.addEventListener('click', toggleAccordion));

// Simulate user authentication status and role
const isAuthenticated = true; // Change this to false to see the hidden links
const userRole = 'admin';     // Change this to 'user' to see the hidden links

// Get references to the links
const profileLink = document.getElementById('profile-link');
const logoutLink = document.getElementById('logout-link');

// Show/hide links based on authentication status and role
if (isAuthenticated) {
    profileLink.classList.remove('hidden');
    logoutLink.classList.remove('hidden');

    // Check if the user role is 'admin' to show additional admin-only links
    if (userRole === 'admin') {
        // Assuming you have elements with IDs 'admin-link-1' and 'admin-link-2'
        const adminLink1 = document.getElementById('admin-link-1');
        const adminLink2 = document.getElementById('admin-link-2');
        adminLink1.classList.remove('hidden');
        adminLink2.classList.remove('hidden');
    }
} else {
    profileLink.classList.add('hidden');
    logoutLink.classList.add('hidden');
}
