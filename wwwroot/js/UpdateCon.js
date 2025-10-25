document.addEventListener("DOMContentLoaded", function () {
    const editModal = document.getElementById("editModal");
    const form = document.getElementById("editForm");

    // Use event delegation so all update buttons work
    document.addEventListener("click", function (e) {
        const updateButton = e.target.closest(".update-contact");
        if (!updateButton) return;

        openEditModal(updateButton.dataset);
        console.log("Update button clicked");
    });

    function openModal() {
        editModal.classList.add('open');
        editModal.setAttribute('aria-hidden', 'false');
    }

    function closeModal() {
        editModal.classList.remove('open');
        editModal.setAttribute('aria-hidden', 'true');
    }

    editModal.addEventListener("click", (e) => {
        if (e.target.hasAttribute("data-close")) {
            closeModal();
        }
    });

    function openEditModal(data) {
        document.getElementById('contactId').value = data.id;
        document.getElementById('contactName').value = data.name;
        document.getElementById('contactPhone').value = data.phone;
        document.getElementById('contactAddress').value = data.address;
        document.getElementById('contactDOB').value = data.dob;
        document.getElementById('contactRemark').value = data.remark;

        openModal();
    }

    form.addEventListener("submit", async function (e) {
        e.preventDefault();

        const formData = new FormData(form);
        const data = Object.fromEntries(formData.entries());

        try {
            const response = await fetch("/Home/UpdatePopUp", {
                method: "POST",
                headers: { "Content-Type": "application/json" },
                body: JSON.stringify(data)
            });

            if (response.ok) {
                alert("Contact updated successfully");
                closeModal();
            } else {
                const error = await response.text();
                alert("Error updating contact: " + error);
            }
        } catch (error) {
            console.log("Error", error);
            alert("An error occurred while updating the contact.");
        }
    });
});
