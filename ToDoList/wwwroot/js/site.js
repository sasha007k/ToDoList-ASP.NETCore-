$(document).ready(function () {

    $('.done-checkbox').on('click', function (e) {
        markDone(e.target);
    });
});


function markDone(checkbox) {    
    
    var row = checkbox.closest('tr');
    $(row).addClass('done');     

    var form = checkbox.closest('form');
    form.submit();
}

