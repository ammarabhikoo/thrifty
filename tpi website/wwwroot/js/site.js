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

document.addEventListener('DOMContentLoaded', function () {
    const popupContainer = document.getElementById('popup-container');
    const closeBtn = document.getElementById('close-popup');
    const emailInput = document.getElementById('email');
    const submitButton = document.getElementById('submit-email');
    const emailError = document.getElementById('email-error'); 

    // Show the pop-up on page load
    popupContainer.style.display = 'flex';

    // Close the pop-up when the close button is clicked
    closeBtn.addEventListener('click', function () {
        popupContainer.style.display = 'none';
    });

    // Handle email submission
    submitButton.addEventListener('click', function () {
        const userEmail = emailInput.value;

        // Basic email validation using a regular expression
        const emailPattern = /^[a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$/;

        if (!emailPattern.test(userEmail)) {
            emailInput.setCustomValidity(''); // Clear any previous custom error message
            emailInput.setCustomValidity('Invalid email address'); // Set the custom error message
            emailError.textContent = 'Error: Invalid email address entered'; // Display the error message
            emailInput.reportValidity(); // Display the error message in the browser
        } else {
            emailInput.setCustomValidity(''); // Clear the custom error message if the email is valid
            emailError.textContent = ''; // Clear the error message
            alert(`Thank you! You submitted: ${userEmail}`);
            popupContainer.style.display = 'none';
        }
    });
});




