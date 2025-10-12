

document.addEventListener('click', function (e) {
    // Open modal on Update click
    
    const updateBtn = e.target.closest('.update-contact');
    if (updateBtn) {
        openEditModal(updateBtn.dataset);
        console.log("update button cliked")
    }

    // Close modal
    if (e.target.closest('[data-close]')) {
        closeModal();
    }
});

function openEditModal(data) {
    const modal = document.getElementById('editModal');

    // Fill inputs with row data
    document.getElementById('contactId').value = data.id;
    document.getElementById('contactName').value = data.name;
    document.getElementById('contactPhone').value = data.phone;
    document.getElementById('contactAddress').value = data.address;
    document.getElementById('contactDOB').value = data.dob;
    document.getElementById('contactRemark').value = data.remark;

    // Show modal
    modal.classList.add('open');
    modal.setAttribute('aria-hidden', 'false');
}

function closeModal() {
    const modal = document.getElementById('editModal');
    modal.classList.remove('open');
    modal.setAttribute('aria-hidden', 'true');
}

// Optional: close on Escape key
document.addEventListener('keydown', function (e) {
    if (e.key === 'Escape') closeModal();
});
